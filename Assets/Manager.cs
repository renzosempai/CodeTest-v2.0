using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

	public Question[] questions;
	private static List<Question> unansweredQuestions;
	public int QuestionCount =0;
	private Question currentQuestion;

	[SerializeField]
	private Text factText;
	[SerializeField]
	private Text trueAnswerText;
	[SerializeField]
	private Text falseAnswerText;

	[SerializeField]
	private Animator animator;
	[SerializeField]
	private	float timeBetweenQuestions = 1f;

	void Start()
	{
		if (unansweredQuestions == null) 
		{
			unansweredQuestions = questions.ToList<Question> ();
			QuestionCount++;
		}

		SetCurrentQuestion ();

	}
	void SetCurrentQuestion()
	{
		if (unansweredQuestions.Count == 0) {
			factText.text = "DONE";
			return;
		}
		int randomQuestionIndex = Random.Range (0, unansweredQuestions.Count);
		currentQuestion = unansweredQuestions [randomQuestionIndex];

		factText.text = currentQuestion.fact;

		if (currentQuestion.isTrue) {
			trueAnswerText.text = "CORRECT";
			falseAnswerText.text = "WRONG";
		} else {
			trueAnswerText.text = "WRONG";
			falseAnswerText.text = "CORRECT";
		}


	}

	IEnumerator TransitionToNextQuestion()
	{
		unansweredQuestions.Remove(currentQuestion);
		yield return new WaitForSeconds (timeBetweenQuestions);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);

	}
	public void UserSelectTrue()
	{
		animator.SetTrigger ("True");
		if (currentQuestion.isTrue) {
			Debug.Log ("Correct");
		} else 
		{
			Debug.Log ("Wrong");
		}
		StartCoroutine (TransitionToNextQuestion ());
	}
	public void UserSelectFalse()
	{
		animator.SetTrigger ("False");
		if (!currentQuestion.isTrue) {
			Debug.Log ("Correct");
		} else 
		{
			Debug.Log ("Wrong");
		}
		StartCoroutine (TransitionToNextQuestion ());
	}

}
