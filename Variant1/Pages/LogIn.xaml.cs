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

namespace Variant1.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        SqlConnection connection = null;
        Frame MainFrame;
        public LogIn(SqlConnection connection, Frame MainFrame)
        {
            InitializeComponent();
            this.connection = connection;
            this.MainFrame = MainFrame;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Aqatoria; Integrated Security=SSPI;");
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand($"Select * From Users Where login= '{LoginBox.Text}' and password = '{PasswordTextBox.Password}' ", connection);
                
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if(reader.Read())
                {
                    Worker worker = new Worker(reader.GetInt32(0), reader.GetString(1));
                    MainFrame.Content = new WorkerPage(worker);
                }
            }
            catch
            {
                ExeptionBlock.Text = "Ошбка подключения";
            }

}
    }
}
