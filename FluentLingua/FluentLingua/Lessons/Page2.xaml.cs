using System.IO;
using System.Windows;
using System.Windows.Controls;
using WMPLib;
namespace FluentLingua.Lessons
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            if (Properties.Settings.Default.lesn1Done == true)
            {
                DoneBtn.Background = System.Windows.Media.Brushes.LightGreen;
            }
        }

        private bool done;
        private WindowsMediaPlayer wplayer;

        private void DoneBtn_Click(object sender, RoutedEventArgs e)
        {
            if ((done == false) &&(Properties.Settings.Default.lesn1Done==false))
            {
                Properties.Settings.Default.lesn1Done = true;
                done = true;
                Properties.Settings.Default.progressCounter++;
                Properties.Settings.Default.Save();
                DoneBtn.Background = System.Windows.Media.Brushes.LightGreen;
            }
        }
        
        private void PlayS(string url)
        {
            wplayer = new WindowsMediaPlayer();
            string path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), url);
            FileInfo fileInfo = new FileInfo(path);
            wplayer.URL = fileInfo.FullName;
            wplayer.controls.play();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PlayS(@"resources\lesson1-1.mp3");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PlayS(@"resources\lesson1-2.mp3");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PlayS(@"resources\lesson1-3.mp3");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            PlayS(@"resources\lesson1-6.mp3");
        }
    }
}
