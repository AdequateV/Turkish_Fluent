using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using FluentLingua.Properties;
namespace FluentLingua
{
    /// <summary>
    /// Interaction logic for LessonsList.xaml
    /// </summary>
    public partial class LessonsList : Page
    {
        public List<LessonSample> l_List { get; set; }
        public LessonsList()
        {
            InitializeComponent();

            


            l_List = new List<LessonSample>();
            var l_0 = new LessonSample("Вступление", 0);
            var l_1 = new LessonSample("Турецкий алфавит. Приветствие", 1);
            var l_2 = new LessonSample("Законы гармонии гласных и согласных", 2);
            var l_3 = new LessonSample("Личные местоимения. Аффиксы сказуемости и др.", 3);
            var l_4 = new LessonSample("Числительные. Притяжательные местоимения", 4);
            var l_5 = new LessonSample("Настоящее время данного момента. Повелительное наклонение и др.", 5);
            var l_6 = new LessonSample("Определительные словосочетания. Служебные слова", 6);
            var l_7 = new LessonSample("Падежи имён", 7);
            var l_8 = new LessonSample("Сравнительная и превосходная степень прилагательных", 8);
            var l_9 = new LessonSample("Прошедшее категорическое время", 9);
            var l_10 = new LessonSample("Будущее категорическое время", 10);
            l_List.Add(l_0);
            l_List.Add(l_1);
            l_List.Add(l_2);
            l_List.Add(l_3);
            l_List.Add(l_4);
            l_List.Add(l_5);
            l_List.Add(l_6);
            l_List.Add(l_7);
            l_List.Add(l_8);
            l_List.Add(l_9);
            l_List.Add(l_10);
            DataContext = this;
        }
        private void HandleDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var track = ((ListViewItem)sender).Content as Track; //Casting back to the binded Track
            int selectedNumber = l_List__.Items.IndexOf(l_List__.SelectedItem);

            //MessageBox.Show("Item Double Click handled!");
            switch (selectedNumber)
            {
                case 0:
                    ListFrame.NavigationService.Navigate(new Uri(@"Lessons\Page1.xaml", UriKind.Relative));
                    l_List__.Visibility = Visibility.Hidden; ListFrame.Refresh();
                    break;
                case 1:
                    ListFrame.NavigationService.Navigate(new Uri(@"Lessons\Page2.xaml", UriKind.Relative));
                    l_List__.Visibility = Visibility.Hidden;
                    break;
                default:
                    break;
            }

        }
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    int selectedNumber = l_List__.Items.IndexOf(l_List__.SelectedItem);
            
        //    switch (selectedNumber)
        //    {
        //        case 0:
        //            ListFrame.NavigationService.Navigate(new Uri(@"Lessons\Page1.xaml", UriKind.Relative));
        //            l_List__.Visibility = Visibility.Hidden; ListFrame.Refresh();
        //            break;
        //        case 1:
        //            ListFrame.NavigationService.Navigate(new Uri(@"Lessons\Page2.xaml", UriKind.Relative));
        //            l_List__.Visibility = Visibility.Hidden;
        //            break;
        //        default:
        //            break;
        //    }

        //}
        
    }
}
