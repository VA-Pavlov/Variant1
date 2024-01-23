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

namespace Variant1.Pages.WorkerPages
{
    /// <summary>
    /// Логика взаимодействия для StartWorkPage.xaml
    /// </summary>
    public partial class StartWorkPage : Page
    {
        TextBlock NumberBoxBlock;
        Worker worker;
        Frame MainFrame;
        public StartWorkPage(TextBlock NumberBoxBlock, Worker worker, Frame mainFrame)
        {
            InitializeComponent();
            this.NumberBoxBlock = NumberBoxBlock;
            this.worker = worker;
            MainFrame = mainFrame;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(NumberBoxBox.Text != null)
            {
                try
                {
                    worker.box = Int32.Parse(NumberBoxBox.Text.Trim());
                    NumberBoxBlock.Text += worker.box;
                    WorkerPage.finishSmenaButton.IsEnabled = true;
                    MainFrame.Content = new ZakazPage(worker);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    NumberBoxBox.Background = new SolidColorBrush(Colors.LightPink);
                }

            }
        }
    }
}
