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
        public StartWorkPage(TextBlock NumberBoxBlock)
        {
            InitializeComponent();
            this.NumberBoxBlock = NumberBoxBlock;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(NumberBoxBox.Text != null)
            {
                NumberBoxBlock.Text += NumberBoxBox.Text.Trim();
            }
        }
    }
}
