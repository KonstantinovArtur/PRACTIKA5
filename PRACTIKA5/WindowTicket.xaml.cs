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
    /// Логика взаимодействия для WindowTicket.xaml
    /// </summary>
    public partial class WindowTicket : Window
    {
        TicketTypeTableAdapter Tic = new TicketTypeTableAdapter();
        public WindowTicket()
        {
            InitializeComponent();
            Dtg.ItemsSource = Tic.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowAdmin windowAdmin = new WindowAdmin();
            windowAdmin.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Tic.InsertQuery(Dob1.Text);
            Dtg.ItemsSource = Tic.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (Dtg.SelectedItem as DataRowView).Row[0];
            Tic.DeleteQuery(Convert.ToInt32(id));
            Dtg.ItemsSource = Tic.GetData();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            object id = (Dtg.SelectedItem as DataRowView).Row[0];
            Tic.UpdateQuery(Dob1.Text, Convert.ToInt32(id));
            Dtg.ItemsSource = Tic.GetData();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            WindowTicketImp windowTicketImp = new WindowTicketImp();    
            windowTicketImp.Show();
            Close();
        }
    }
}
