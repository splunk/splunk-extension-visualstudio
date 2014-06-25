using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;

namespace ModularInputWizard
{
    public class Wizard : IWizard
    {
        private WizardWindow wizardPage;

        public Wizard() { }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, 
            WizardRunKind runKind, object[] customParams)
        {
            ModularInputMetadata model = new ModularInputMetadata();

            wizardPage = new WizardWindow(model);
            Nullable<bool> dialogCompleted = wizardPage.ShowDialog();

            if (dialogCompleted == true)
            {
                replacementsDictionary.Add("$label$", model.Label);
                replacementsDictionary.Add("$visibleInLauncher$", model.VisibleInLauncher ? "true" : "false");
                replacementsDictionary.Add("$author$", model.Author);
                replacementsDictionary.Add("$version$", model.Version);
                replacementsDictionary.Add("$description$", model.Description);
                replacementsDictionary.Add("$generateExampleImplementation$", model.GenerateExampleImplementation ? "true" : "false");
            }
            else
            {
                throw new WizardCancelledException();
            }
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
