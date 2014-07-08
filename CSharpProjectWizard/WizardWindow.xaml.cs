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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSharpProjectWizard
{
    public enum Logging { None, TraceListener, Slab };

    public class ProjectMetadata : DependencyObject
    {
        public ProjectMetadata()
        {
            UseLogging = Logging.None;
            GenerateExample = true;
        }
        
        public static readonly DependencyProperty UseLoggingProperty =
            DependencyProperty.Register("UseLogging", typeof(Logging), typeof(WizardWindow), new UIPropertyMetadata());
        public Logging UseLogging
        {
            get { return (Logging)GetValue(UseLoggingProperty); }
            set { SetValue(UseLoggingProperty, value); }
        }

        public static readonly DependencyProperty GenerateExampleProperty =
            DependencyProperty.Register("GenerateExample", typeof(bool), typeof(WizardWindow), new UIPropertyMetadata());
        public bool GenerateExample
        {
            get { return (bool)GetValue(GenerateExampleProperty); }
            set { SetValue(GenerateExampleProperty, value); }
        }
    }
    
    /// <summary>
    /// Interaction logic for WizardWindow.xaml
    /// </summary>
    public partial class WizardWindow : Window
    {

        public WizardWindow(ProjectMetadata model)
        {
            InitializeComponent();
            this.DataContext = model;
            this.Owner = Application.Current.MainWindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
