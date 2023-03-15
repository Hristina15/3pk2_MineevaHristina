using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var task1 = GetPower(50, 20);
            var task2 = GetPower(23, 2);
            var task3 = GetPower(45, 12);

            long[] task = await Task.WhenAll(task1, task2, task3);
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;

            worker.RunWorkerAsync();




        }
        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                (sender as BackgroundWorker).ReportProgress(i);
                Thread.Sleep(100);
            }
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbStatus.Value = e.ProgressPercentage;
        }





        async static Task SomeMetohd()
        {
            int val = 10;
            await Task.Delay(TimeSpan.FromSeconds(0.5));
            val *= val;

            await Task.Delay(TimeSpan.FromSeconds(0.5));
            Console.WriteLine("SomeMetodh end");
        }
        async static Task<long> GetPower(long a, int i)
        {
            for (int k = 0; k < i; k++)
            {
                a *= a;
                Console.WriteLine($"{i} : result");
                Task.Delay(TimeSpan.FromSeconds(0.5));
            }
            Console.WriteLine(a);
            return a;
        }

        private void ProgressBar_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

    }
}
