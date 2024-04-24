using System;
using System.Collections.Generic;
using System.Data;
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
using PRACTIKA5.PRACTIKADataSetTableAdapters;

namespace PRACTIKA5
{
    /// <summary>
    /// Логика взаимодействия для WindowCountries1.xaml
    /// </summary>
    public partial class WindowCountries1 : Window
    {
        CountriesTableAdapter Coun = new CountriesTableAdapter();
        public WindowCountries1()
        {
            InitializeComponent();
            Dtg.ItemsSource = Coun.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Dtg.ItemsSource = Coun.SearchByName(Dob1.Text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Dtg.ItemsSource = Coun.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowBuyer windowBuyer = new WindowBuyer();
            windowBuyer.Show();
            Close();
        }
    }
}
