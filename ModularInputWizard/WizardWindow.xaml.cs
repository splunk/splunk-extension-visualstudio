using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ModularInputWizard
{
    public class ModularInputMetadata : DependencyObject
    {
        public ModularInputMetadata()
        {
            Author = "";
            Label = "";
            VisibleInLauncher = false;
            Description = "";
            Version = "0.1.0";
            GenerateExampleImplementation = true;
        }

        public static readonly DependencyProperty AuthorProperty =
            DependencyProperty.Register("Author", typeof(string), typeof(WizardWindow), new UIPropertyMetadata());
        public string Author
        {
            get { return (string)GetValue(AuthorProperty); }
            set { SetValue(AuthorProperty, value); }
        }

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(WizardWindow), new UIPropertyMetadata());
        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public static readonly DependencyProperty VisibleInLauncherProperty =
            DependencyProperty.Register("VisibleInLauncher", typeof(bool), typeof(WizardWindow), new UIPropertyMetadata());
        public bool VisibleInLauncher
        {
            get { return (bool)GetValue(VisibleInLauncherProperty); }
            set { SetValue(VisibleInLauncherProperty, value); }
        }

        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register("Description", typeof(string), typeof(WizardWindow), new UIPropertyMetadata());
        public string Description
        {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }

        public static readonly DependencyProperty VersionProperty =
    DependencyProperty.Register("Version", typeof(string), typeof(WizardWindow), new UIPropertyMetadata());
        public string Version
        {
            get { return (string)GetValue(VersionProperty); }
            set { SetValue(VersionProperty, value); }
        }

        public static readonly DependencyProperty GenerateExampleImplementationProperty = 
            DependencyProperty.Register("GenerateExampleImplementation", typeof(bool), typeof(WizardWindow), new UIPropertyMetadata());
        public bool GenerateExampleImplementation
        {
            get { return (bool)GetValue(GenerateExampleImplementationProperty); }
            set { SetValue(GenerateExampleImplementationProperty, value); }
        }
        
    }

    /// <summary>
    /// Interaction logic for WizardWindow.xaml
    /// </summary>
    public partial class WizardWindow : Window
    {
        public WizardWindow(ModularInputMetadata model)
        {
            InitializeComponent();
            this.DataContext = model;
            this.VersionTextBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            this.AuthorTextBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            this.Owner = Application.Current.MainWindow;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
