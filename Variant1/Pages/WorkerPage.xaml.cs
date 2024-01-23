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
using Variant1.Pages.WorkerPages;

namespace Variant1.Pages
{
    /// <summary>
    /// Логика взаимодействия для WorkerPage.xaml
    /// </summary>
    public partial class WorkerPage : Page
    {
        Worker worker;
        public WorkerPage(Worker worker)
        {
            InitializeComponent();
            this.worker = worker;
            NameBox.Text = worker.name;
            ManeWorkerFrame.Content = new StartWorkPage(NumberBoxBlock);
        }
    }
}
