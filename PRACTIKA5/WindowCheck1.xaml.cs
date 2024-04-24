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
    /// Логика взаимодействия для WindowCheck1.xaml
    /// </summary>
    public partial class WindowCheck1 : Window
    {
        Check_TableAdapter Check = new Check_TableAdapter();
        public WindowCheck1()
        {
            InitializeComponent();
            Dtg.ItemsSource = Check.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowBuyer windowBuyer = new WindowBuyer();
            windowBuyer.Show();
            Close();
        }

        
    }
}
