using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModularInputProjectWizard
{
    public partial class ModularInputForm : Form
    {
        public string Author { get; private set; }
        public string Version { get; private set; }
        public string Description { get; private set; }
        public bool VisibleInLauncher { get; private set; }


        public ModularInputForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Author = this.AuthorTextbox.Text;
            if (Author.Equals(""))
            {
                MessageBox.Show("You must specify an author for this modular input.");
                return;
            }

            Version = this.VersionTextbox.Text;
            if (Version.Equals(""))
            {
                MessageBox.Show("You must specify a version for this modular input.");
                return;
            }

            VisibleInLauncher = VisibleInLauncherCheckbox.Checked;

            Description = this.DescriptionTextbox.Text;

            DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }
}
