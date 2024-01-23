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
    /// Логика взаимодействия для OrdersPanelPage.xaml
    /// </summary>
    public partial class OrdersPanelPage : Page
    {
        public OrdersPanelPage()
        {
            InitializeComponent();
            SqlCommand cmd = new SqlCommand("Select Discriptions from Services;", MainWindow.connect);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Content = reader.GetString(0);
                ServicesList.Children.Add(checkBox);
            }
            reader.Close();
        }
    }
}
