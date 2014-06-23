using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using Microsoft.Win32;
using System.Windows;
using System.Net;

namespace BeaconWizard
{
    class Wizard : IWizard
    {
        private const string beaconKey = "SendUsageInformation";
        private const Uri phoneHomeUri = new Uri("???");

        public Wizard() { }

        public void RunStarted(object automationObject, 
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
        {
            var r = Registry.CurrentUser.CreateSubKey("Software\\Splunk");
            
            if (r.GetValue(beaconKey, null) == null)
            {
                // No key was set; ask the user if they want to opt-in.
                MessageBoxResult result = MessageBox.Show(
                    "Opt in or out!",
                    "Caption",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.None
                );

                r.SetValue(beaconKey, result == MessageBoxResult.Yes);
            }

            try {
                if ((bool)r.GetValue(beaconKey))
                {
                    string asset = replacementsDictionary["BeaconAsset"];
                    string action = replacementsDictionary["BeaconAction"];

                    var req = WebRequest.Create(phoneHomeUri);
                    req.Method = "HEAD";
                    req.GetResponseAsync();

                }
            }
            catch (Exception) { /* Do nothing */ }
        }

        // Always return true; this IWizard implementation throws a WizardCancelledException 
        // that is handled by Visual Studio if the user cancels the wizard. 
        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }

        // The following IWizard methods are not implemented in this wizard.
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }
    }
}
