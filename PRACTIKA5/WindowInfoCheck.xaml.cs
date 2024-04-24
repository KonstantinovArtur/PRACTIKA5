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
    /// Логика взаимодействия для WindowInfoCheck.xaml
    /// </summary>
    public partial class WindowInfoCheck : Window
    {
        CheckInfoTableAdapter CheckIno = new CheckInfoTableAdapter();
        public WindowInfoCheck()
        {
            InitializeComponent();
            Dtg.ItemsSource = CheckIno.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowAdmin windowAdmin = new WindowAdmin();
            windowAdmin.Show();
            Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CheckIno.InsertQuery(Dob1.Text, Convert.ToInt32(Dob2.Text), Dob3.Text, Convert.ToInt32(Dob4.Text));
            Dtg.ItemsSource = CheckIno.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (Dtg.SelectedItem as DataRowView).Row[0];
            CheckIno.DeleteQuery(Convert.ToInt32(id));
            Dtg.ItemsSource = CheckIno.GetData();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            object id = (Dtg.SelectedItem as DataRowView).Row[0];
            CheckIno.UpdateQuery(Dob1.Text, Convert.ToInt32(Dob2.Text), Dob3.Text, Convert.ToInt32(Dob4.Text), Convert.ToInt32(id));
            Dtg.ItemsSource = CheckIno.GetData();
        }

       
    }
}
