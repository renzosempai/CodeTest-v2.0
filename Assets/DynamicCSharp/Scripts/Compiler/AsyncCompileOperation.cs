﻿using System;
using System.Collections;
using System.Threading;
using UnityEngine;

namespace DynamicCSharp.Compiler
{
    /// <summary>
    /// A yieldable instruction that can be used inside a coroutine to wait for an async opertation to exit without blocking the main thread.
    /// <example><code>IEnumerator WaitWithoutBlocking()
    /// {
    ///     // AsyncCompileOperation is returned by all async methods
    ///     AsyncCompileOperation task;
    ///     yield return task;
    /// }
    /// </code></example>
    /// </summary>
    public class AsyncCompileOperation : CustomYieldInstruction
    {
        // Private
        private ScriptCompiler handler = null;
        private Func<bool> asyncCallback = null;
        private volatile bool threadExit = false;
        private bool hasStarted = false;

        // Protected
        /// <summary>
        /// The byte data representing the compiled output assembly.
        /// </summary>
        protected byte[] assemblyData = null;
        /// <summary>
        /// A string array of all errors generated by the compile operation.
        /// </summary>
        protected string[] errors = null;
        /// <summary>
        /// A string array of all warnings generated by the compile operation.
        /// </summary>
        protected string[] warnings = null;
        /// <summary>
        /// Was the compile successful.
        /// </summary>
        protected bool isSuccessful = false;
        /// <summary>
        /// Has the compile completed. 
        /// </summary>
        protected bool isDone = false;

        // Properties
        /// <summary>
        /// Get the byte data of the compiled output assembkly.
        /// </summary>
        public byte[] AssemblyData
        {
            get { return assemblyData; }
        }

        /// <summary>
        /// Get an array of compiler errors generated by the compile operation.
        /// </summary>
        public string[] CompilerErrors
        {
            get { return errors; }
        }

        /// <summary>
        /// Get an array of compiler warnings generated by the compile operation.
        /// </summary>
        public string[] CompilerWarnings
        {
            get { return warnings; }
        }

        /// <summary>
        /// Get a value indicating whether the compile operation was successful or not.
        /// </summary>
        public bool IsSuccessful
        {
            get { return isSuccessful; }
        }

        /// <summary>
        /// Get a value indicating whether the compile operation has finished or is still running.
        /// </summary>
        public bool IsDone
        {
            get { return isDone; }
        }

        /// <summary>
        /// Override implementaiton of <see cref="CustomYieldInstruction"/>. 
        /// </summary>
        public override bool keepWaiting
        {
            get
            {
                // Start the task if it has not already been started
                if (hasStarted == false)
                {
                    // Set flag - set to false on error
                    isSuccessful = true;
                    
                    // Queue the work item
                    ThreadPool.QueueUserWorkItem((object state) =>
                    {
                        // Call the main method
                        try
                        {
                            // Call the async method
                            if (asyncCallback != null)
                                if (asyncCallback() == false)
                                    isSuccessful = false;
                        }
                        catch (Exception e)
                        {
                            Debug.LogException(e);
                            isSuccessful = false;
                        }

                        // Set the complete flag
                        threadExit = true;
                    });

                    // Set the started flag
                    hasStarted = true;
                }

                // Keep advancing until the thread exits
                if (threadExit == false)
                    return true;
                
                // Call the sync method
                try
                {
                    // Do filal work on main thread
                    DoSyncFinalize();
                }
                catch (Exception e)
                {
                    Debug.LogException(e);
                    isSuccessful = false;
                }

                // Check for success
                if (handler.HasErrors == true)
                    isSuccessful = false;

                // Task has finished
                isDone = true;
                return false;
            }
        }

        // Constructor
        internal AsyncCompileOperation(ScriptCompiler handler, Func<bool> asyncCallback)
        {
            this.handler = handler;
            this.asyncCallback = asyncCallback;
        }

        // Methods
        /// <summary>
        /// Called once the async method has exited to allow cleanup.
        /// This will be called from the main thread.
        /// </summary>
        protected virtual void DoSyncFinalize()
        {
            this.assemblyData = handler.AssemblyData;
            this.errors = handler.Errors;
            this.warnings = handler.Warnings;
        }

        /// <summary>
        /// New imeplementation of <see cref="Reset"/>.
        /// Resets the state of this async operation.
        /// </summary>
        public new void Reset()
        {
            threadExit = false;
            isSuccessful = false;
            isDone = false;
            hasStarted = false;
        }
    }
}
