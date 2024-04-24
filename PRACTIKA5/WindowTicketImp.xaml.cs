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
using PRACTIKA5.Model;
using PRACTIKA5.PRACTIKADataSetTableAdapters;

namespace PRACTIKA5
{
    /// <summary>
    /// Логика взаимодействия для WindowTicketImp.xaml
    /// </summary>
    public partial class WindowTicketImp : Window
    {
        TicketTypeTableAdapter tic = new TicketTypeTableAdapter();
        public WindowTicketImp()
        {
            InitializeComponent();
            Dtg.ItemsSource = tic.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowTicket ticket = new WindowTicket();   
            ticket.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<TicketModel> forimport = LabaConverter.DeserializeObject<List<TicketModel>>();
            foreach (var item in forimport)
            {
                tic.InsertQuery(item.TicketType);
            }
            Dtg.ItemsSource = tic.GetData();
        }
    }
}
