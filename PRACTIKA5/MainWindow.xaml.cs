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
using System.Windows.Navigation;
using System.Windows.Shapes;
using PRACTIKA5.PRACTIKADataSetTableAdapters;


namespace PRACTIKA5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UsersTableAdapter adapter = new UsersTableAdapter();
        public MainWindow()
        {
            InitializeComponent();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var allLogins = adapter.GetData().Rows;
            
            for (int i=0; i<allLogins.Count; i++)
            {
                if (allLogins[i][5].ToString() == Log.Text && allLogins[i][6].ToString() == Pas.Password)
                {
                    int roleID = (int)allLogins[i][4];
                   

                    switch (roleID)
                    {
                        case 1:
                            WindowAdmin role = new WindowAdmin();
                            role.Show();
                            Close();
                            break;
                        case 2:
                            WindowBuyer sec = new WindowBuyer();
                            sec.Show();
                            Close();
                            break;
                    }
                }
                
              
            }
        }
    }
}
