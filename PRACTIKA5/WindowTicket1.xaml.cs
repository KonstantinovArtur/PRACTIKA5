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
    /// Логика взаимодействия для WindowTicket1.xaml
    /// </summary>
    public partial class WindowTicket1 : Window
    {
        TicketTypeTableAdapter Tic = new TicketTypeTableAdapter();
        public WindowTicket1()
        {
            InitializeComponent();
            Dtg.ItemsSource = Tic.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowBuyer windowBuyer = new WindowBuyer();
            windowBuyer.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Dtg.ItemsSource = Tic.SearchByName(Dob1.Text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Dtg.ItemsSource = Tic.GetData();
        }

        
    }
}
