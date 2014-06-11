using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TemplateWizard;
using EnvDTE;
using System.Windows.Forms;
using System.IO;

namespace Splunk.VisualStudio
{
    public class ModularInputProjectWizard : IWizard
    {
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        // This method is only called for item templates,
        // not for project templates.
        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        // This method is called after the project is created.
        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject,
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
        {
            try
            {
                ModularInputForm form = new ModularInputForm();
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    replacementsDictionary.Add("$author$", form.Author);
                    replacementsDictionary.Add("$version$", form.Version);
                    replacementsDictionary.Add("$visibleInLauncher$", form.VisibleInLauncher.ToString());
                    replacementsDictionary.Add("$description$", form.Description);
                    replacementsDictionary.Add("$label$", form.Label);
                }
                else
                {
                    throw new WizardCancelledException();
                }
            }
            catch (Exception)
            {
                if (Directory.Exists(replacementsDictionary["$destinationDirectory$"]))
                    Directory.Delete(replacementsDictionary["$destinationDirectory$"]);
                throw;
            }
        }

        // This method is only called for item templates,
        // not for project templates.
        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }   
    }
}
