using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для WindowTour1.xaml
    /// </summary>
    public partial class WindowTour1 : Window
    {
       
        ProductTableAdapter Pr = new ProductTableAdapter();
        DescriptionTourTableAdapter Ds = new DescriptionTourTableAdapter();
        public WindowTour1()
        {
            InitializeComponent();
            Dtg.ItemsSource = Pr.GetData();
            Do.ItemsSource = Ds.GetData();
            Do.DisplayMemberPath="DescriptionTour_ID";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowBuyer windowBuyer = new WindowBuyer();
            windowBuyer.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Dtg.ItemsSource = Pr.SearchByName(Dob1.Text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Dtg.ItemsSource = Pr.GetData();
        }

        private void Do_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Do.SelectedItem != null)
            {
                var id = (int)(Do.SelectedItem as DataRowView).Row[0];
                Dtg.ItemsSource = Pr.Filter(id);
            }
        }
    }
}
