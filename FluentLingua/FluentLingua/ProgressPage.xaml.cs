using System.Windows.Controls;
using FluentLingua;
namespace FluentLingua
{
    /// <summary>
    /// Interaction logic for ProgressPage.xaml
    /// </summary>
    public partial class ProgressPage : Page
    {
        public ProgressPage()
        {
            InitializeComponent();
            Progressbar.Maximum = 27;
            try
            {
                Progressbar.Value = Properties.Settings.Default.progressCounter;
            }
            catch { }
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            Properties.Settings.Default.progressCounter = 0;
            Properties.Settings.Default.lesn1Done = false;
            Properties.Settings.Default.Save();
        }
    }
}
