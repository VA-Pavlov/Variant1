using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Variant1.Pages.KlientPages
{
    /// <summary>
    /// Логика взаимодействия для KlientPage.xaml
    /// </summary>
    public partial class KlientPage : Page
    {
        SqlConnection connection;
        public KlientPage(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow.mainFrame.Content = new OrdersPanelPage();
        }
    }
}
