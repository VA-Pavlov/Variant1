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
using Variant1.Pages.KlientPages;

namespace Variant1.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogIn.xaml
    /// </summary>
    public partial class LogIn : Page 
    { 
        Frame MainFrame;
        Window window;
        public LogIn(Frame MainFrame, Window window)
        {
            InitializeComponent();
            this.window = window;
            this.MainFrame = MainFrame;
            try
            {
                MainWindow.connect = new SqlConnection(@"Data Source=VIACHESLAV; Initial Catalog=Aqatoria; Integrated Security=SSPI;");
                MainWindow.connect.Open();
                LogInButton.IsEnabled = true;
                ExeptionBlock.Text = "Подключение установлено";
            }
            catch
            {
                ExeptionBlock.Text = "Ошбка подключения";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand($"Select * From Users Where UsLogin= '{LoginBox.Text}' and UsPassword = '{PasswordTextBox.Password}' ", MainWindow.connect);

            SqlDataReader reader=null;
            try
            {

                reader = sqlCommand.ExecuteReader();
                if(reader.Read())
                {
                    Worker worker = new Worker(reader.GetInt32(0), reader.GetString(3));
                    if (reader.GetInt32(4) == 2)
                    {
                        
                        MainFrame.Content = new WorkerPage(worker);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                ExeptionBlock.Text = "Неверный логин или пароль";
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            window.WindowState = WindowState.Maximized;
            window.WindowStyle = WindowStyle.None;
            MainFrame.Content = new KlientPage(MainWindow.connect);
        }
    }
}
