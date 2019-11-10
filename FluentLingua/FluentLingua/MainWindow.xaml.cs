using System;
using System.Windows;
namespace FluentLingua
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool updated = false;
        public MainWindow()
        {
            InitializeComponent();
            frame.NavigationService.Navigate(new Uri("ProgressPage.xaml", UriKind.Relative));
            //frame.LoadCompleted += Frame_LoadCompleted;
        }

        //private void Frame_LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        //{
        //    frame.Refresh();
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    frame.NavigationService.Navigate(new Uri("ProgressPage.xaml", UriKind.Relative));
        //    frame.Refresh();
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new ProgressPage();
            
        }
        private void Button_lessons_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new LessonsList();
        }
        //private void Button_lessons_Click(object sender, RoutedEventArgs e)
        //{
        //    //frame.NavigationService.Navigate(new Uri("MainWindow.xaml"), UriKind.Relative);
        //    frame.NavigationService.Navigate(new Uri("LessonsList.xaml", UriKind.Relative));
        //    frame.Refresh();

        //}

        //Меню сначала видимое, затем по нажатию одной из двух кнопок, оно скрывается и появляется только при наведении
        private void StackPanel_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            StackPanel.Opacity = 0.1;
        }

        private void StackPanel_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            StackPanel.Opacity = 1;
        }
    }
}
