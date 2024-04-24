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

namespace PRACTIKA5
{
    /// <summary>
    /// Логика взаимодействия для WindowBuyer.xaml
    /// </summary>
    public partial class WindowBuyer : Window
    {
        public WindowBuyer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowCheck1 windowCheck1 = new WindowCheck1();
            windowCheck1.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowTour1 windowTour1 = new WindowTour1();
            windowTour1.Show();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WindowDescription1 a = new WindowDescription1();
            a.Show();
            Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            WindowCountries1 a = new WindowCountries1();    
            a.Show();
            Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            WindowAvia1 a = new WindowAvia1();
            a.Show();
            Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            WindowTicket1 a = new WindowTicket1();
            a.Show();
            Close();
        }
    }
}
