﻿using UnityEngine;
using UnityEditor;
using EditorDesignerUI;
using EditorDesignerUI.Controls;
using DynamicCSharp.Compiler;

namespace DynamicCSharp.Editor
{
    [InitializeOnLoad]
    public sealed class AutomaticInstaller : DesignerWindow
    {
        // Private
        private Texture2D tick = null;
        private Texture2D cross = null;
        
        // Methods
        [InitializeOnLoadMethod]
        public static void EditorStart()
        {
            if (EditorPrefs.HasKey("DynamicC#-Installed") == false)
            {
                ShowWindow();
                EditorPrefs.SetBool("DynamicC#-Installed", true);
            }
        }

        [MenuItem("Tools/Dynamic C#/Installer", priority = 0)]
        public static AutomaticInstaller ShowWindow()
        {
            return ShowWindow<AutomaticInstaller>();
        }

        public override void OnEnable()
        {
            WindowTitle = "Auto Installer";
            
            // Load textures
            tick = ImageUtility.Find("TickIcon");
            cross = ImageUtility.Find("CrossIcon");

            // Create ui controls
            CreateUI();

            // Add a constant repaint listener
            EditorApplication.update += Repaint;
        }

        public override void OnDisable()
        {
            // Remove listener
            EditorApplication.update -= Repaint;
        }

        private void CreateUI()
        {
            Label label = AddControl<Label>();
            {
                label.Content.Text = "Dynamic C# Installer";
                label.Style = new VisualStyle(EditorStyle.BoldLabel);
            }

            AddControl<Spacer>();

            HelpBox help = AddControl<HelpBox>();
            {
                help.Content.Text = "This installer is only required if you need support for runtime script compilation. If you are using managed assemblies only then you can skip this install process. You can always come back to this installer at a later date from 'Tools -> Dynamic C# -> Installer'";
                help.HelpType = HelpBoxType.Info;
            }

            AddControl<Spacer>();

            Label helpLabel = AddControl<Label>();
            {
                helpLabel.Content.Text = "The following actions need to be performed:";
                helpLabel.Style = new VisualStyle(EditorStyle.BoldLabel);
                helpLabel.Layout.Size = new Vector2(0, 0);
            }

            HorizontalLayout compatibilityLayout = AddControl<HorizontalLayout>();
            {
                // Tab spacer
                compatibilityLayout.AddControl<Spacer>().Spacing = 20;

                // Image
                Image img = compatibilityLayout.AddControl<Image>();
                {
                    img.Content.Texture = (IsCompatibilitySet() == true) ? tick : cross;
                    img.Layout.Size = new Vector2(12, 12);
                }

                Label text = compatibilityLayout.AddControl<Label>();
                {
                    text.Content.Text = "-Change API compatibility level to '.NET 2.0'";
                    text.Layout.Size = new Vector2(0, 0);
                }
            }

            HorizontalLayout compilerLayout = AddControl<HorizontalLayout>();
            {
                // Tab spacer
                compilerLayout.AddControl<Spacer>().Spacing = 20;

                // Image
                Image img = compilerLayout.AddControl<Image>();
                {
                    img.Content.Texture = (IsCompilerInstalled() == true) ? tick : cross;
                    img.Layout.Size = new Vector2(12, 12);
                }

                Label text = compilerLayout.AddControl<Label>();
                {
                    text.Content.Text = "-Import the compiler package";
                    text.Layout.Size = new Vector2(0, 0);
                }
            }

            AddControl<FlexibleSpacer>();

            CenterLayout center = AddControl<CenterLayout>();
            {
                Button button = center.AddControl<Button>();
                {
                    button.Content.Text = "Install";
                    button.Layout.Size = new Vector2(100, 30);
                    button.Enabled = !(IsCompatibilitySet() && IsCompilerInstalled());
                    button.OnClicked += InstallCompiler;
                }
            }
        }

        private bool IsCompatibilitySet()
        {
            return (PlayerSettings.apiCompatibilityLevel == ApiCompatibilityLevel.NET_2_0);
        }

        private bool IsCompilerInstalled()
        {
            return Compiler.ScriptCompiler.CompilerType != null;
        }

        private void InstallCompiler(object sender)
        {
            // Modify API compatibility
            if(IsCompatibilitySet() == false)
            {
                // Change the value
                PlayerSettings.apiCompatibilityLevel = ApiCompatibilityLevel.NET_2_0;
            }

            // Import the package
            AssetDatabase.ImportPackage(DynamicCSharp.InstallLocation + "/Resources/Editor/CompilerPackage.unitypackage", false);

            // Re-show the window
            ShowWindow();
        }
    }
}
