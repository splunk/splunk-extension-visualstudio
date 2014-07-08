using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;

namespace CSharpProjectWizard
{
    class Wizard : IWizard
    {
        private WizardWindow wizardPage;

        public Wizard() { }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary,
           WizardRunKind runKind, object[] customParams)
        {
            ProjectMetadata model = new ProjectMetadata();

            wizardPage = new WizardWindow(model);
            Nullable<bool> dialogCompleted = wizardPage.ShowDialog();

            if (dialogCompleted == true)
            {
                replacementsDictionary.Add("$generateExampleImplementation$", model.GenerateExample ? "true" : "false");
                if (model.UseLogging == Logging.None) {
                    replacementsDictionary.Add("$logging$", "none");
                }
                else if (model.UseLogging == Logging.TraceListener)
                {
                    replacementsDictionary.Add("$logging$", "tracelistener");
                }
                else if (model.UseLogging == Logging.Slab)
                {
                    replacementsDictionary.Add("$logging$", "slab");
                }
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
