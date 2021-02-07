using Juster.Music.ViewModels;
using System;
using System.Threading;
using System.Windows;

namespace Juster.Music
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            //Thread.Sleep(1000 * 10);

            Thread subthread = new Thread(SubthreadAction);
            subthread.IsBackground = true;
            subthread.Start();
        }

        private void SubthreadAction(object obj)
        {
            //复杂耗时操作
            Thread.Sleep(1000 * 10);
        }
    }
}
