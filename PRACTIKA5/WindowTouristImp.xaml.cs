using PRACTIKA5.Model;
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
using PRACTIKA5.PRACTIKADataSetTableAdapters;

namespace PRACTIKA5
{
    /// <summary>
    /// Логика взаимодействия для WindowTouristImp.xaml
    /// </summary>
    public partial class WindowTouristImp : Window
    {
        TouristTableAdapter tou = new TouristTableAdapter();
        public WindowTouristImp()
        {
            InitializeComponent();
            Dtg.ItemsSource = tou.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowTourist windowTourist = new WindowTourist();
            windowTourist.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<TouristModel> forimport = LabaConverter.DeserializeObject<List<TouristModel>>();
            foreach (var item in forimport)
            {
                tou.InsertQuery(Convert.ToString(item.Num_Human), item.Age_category);
            }
            Dtg.ItemsSource = tou.GetData();
        }
    }
}
