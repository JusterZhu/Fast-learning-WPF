using Juster.Logger;
using Juster.Music.ViewModels;
using Juster.Music.Views;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace Juster.Music
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _isPlay;
        private MainViewModel vm;

        public MainWindow()
        {
            InitializeComponent();
            vm = new MainViewModel();
            vm.View = this;
            DataContext = vm;
        }

        private void Grid_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var loginView = new LoginView();
            loginView.ShowDialog();
            var vm = loginView.DataContext as LoginViewModel;
            UserNameTb.Text = vm.Account;
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            if (_isPlay)
            {
                Media.Stop();
                _isPlay = false;
            }
            else
            {
                Media.Play();
                _isPlay = true;
            }
        }

        private void DgdSongs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Media.Stop();
            Media.Play();
            _isPlay = true;
        }

        public void SetSource(string path) 
        {
            Media.Source = new Uri(path,UriKind.Absolute);
        }
    }
}
