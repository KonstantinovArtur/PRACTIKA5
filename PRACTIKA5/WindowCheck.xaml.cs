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
    /// Логика взаимодействия для WindowCheck.xaml
    /// </summary>
    public partial class WindowCheck : Window
    {
        Check_TableAdapter Check = new Check_TableAdapter();
        public WindowCheck()
        {
            InitializeComponent();
            Dtg.ItemsSource = Check.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowAdmin admin = new WindowAdmin();
            admin.Show();
            Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Check.InsertQuery(Convert.ToInt32(Dob1.Text), Convert.ToInt32(Dob2.Text));
            Dtg.ItemsSource = Check.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (Dtg.SelectedItem as DataRowView).Row[0];
            Check.DeleteQuery(Convert.ToInt32(id));
            Dtg.ItemsSource = Check.GetData();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            object id = (Dtg.SelectedItem as DataRowView).Row[0];
            Check.UpdateQuery(Convert.ToInt32(Dob1.Text), Convert.ToInt32(Dob2.Text), Convert.ToInt32(id));
            Dtg.ItemsSource = Check.GetData();
        }

       
    }
}
