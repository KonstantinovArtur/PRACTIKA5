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
    /// Логика взаимодействия для WindowUser.xaml
    /// </summary>
    public partial class WindowUser : Window
    {
       
        UsersTableAdapter Users = new UsersTableAdapter();
        public WindowUser()
        {
            InitializeComponent();
            Dtg.ItemsSource = Users.GetData();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowAdmin windowBuyer = new WindowAdmin();
            windowBuyer.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Users.InsertQuery(Dob1.Text, Dob2.Text, Dob3.Text, Convert.ToInt32(Dob4.Text), Dob5.Text, Dob6.Text, Convert.ToInt32(Dob7.Text));
            Dtg.ItemsSource = Users.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (Dtg.SelectedItem as DataRowView).Row[0];
            Users.DeleteQuery(Convert.ToInt32(id));
            Dtg.ItemsSource = Users.GetData();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            object id = (Dtg.SelectedItem as DataRowView).Row[0];
            Users.UpdateQuery(Dob1.Text, Dob2.Text, Dob3.Text, Convert.ToInt32(Dob4.Text), Dob5.Text, Dob6.Text, Convert.ToInt32(Dob7.Text), Convert.ToInt32(id));
            Dtg.ItemsSource = Users.GetData();
        }

       
    }
}
