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
    /// Логика взаимодействия для WindowAdmin.xaml
    /// </summary>
    public partial class WindowAdmin : Window
    {
        public WindowAdmin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowUser a = new WindowUser();
            a.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowRole a = new WindowRole();
            a.Show();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WindowTourist a = new WindowTourist();
            a.Show();
            Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            WindowCheck a = new WindowCheck();
            a.Show();
            Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            WindowInfoCheck windowInfoCheck = new WindowInfoCheck();
            windowInfoCheck.Show();
            Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            WindowTour windowInfoCheck = new WindowTour();
            windowInfoCheck.Show();
            Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            WindowDescription windowDescription = new WindowDescription();  
            windowDescription.Show();
            Close();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            WindowCountries windowCountries = new WindowCountries();
            windowCountries.Show(); 
            Close();

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            WindowAvia windowAvia = new WindowAvia();   
            windowAvia.Show();
            Close();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            WindowTicket windowTicket = new WindowTicket();
            windowTicket.Show();
            Close();
        }
    }
}
