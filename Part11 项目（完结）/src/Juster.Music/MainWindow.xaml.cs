using Juster.Logger;
using Juster.Music.ViewModels;
using Juster.Music.Views;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Juster.Music
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _isPlay;
        private MainViewModel _vm;
        private DispatcherTimer _timer = null;


        public MainWindow()
        {
            InitializeComponent();
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += new EventHandler(UpdateAction);
            
            _vm = new MainViewModel();
            _vm.View = this;
            DataContext = _vm;
            Media.MediaOpened += OnMediaOpened;
            sliderPosition.ValueChanged += OnValueChanged;
            TxbTimeEnd.Text = "00:00:00";
            TxbTimeStart.Text = "00:00:00";
        }

        /// <summary>
        /// 拖动进度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Media.Position = TimeSpan.FromSeconds(sliderPosition.Value);
        }

        /// <summary>
        /// 获取音乐时长
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMediaOpened(object sender, RoutedEventArgs e)
        {
            var time = Media.NaturalDuration.TimeSpan.TotalSeconds;
            sliderPosition.Minimum = 0;
            sliderPosition.Maximum = time;
            TxbTimeEnd.Text = ConvertTime(time);
        }

        /// <summary>
        /// 更新播放进度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateAction(object sender, EventArgs e)
        {
            var time = Media.Position.TotalSeconds;
            sliderPosition.Value = time;
            TxbTimeStart.Text = ConvertTime(time);
        }

        /// <summary>
        /// 拖动窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                _timer.Stop();
            }
            else
            {
                Media.Play();
                _isPlay = true;
                _timer.Start();
            }
        }

        private void DgdSongs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Media.Stop();
            Media.Play();
            _timer.Start();
            _isPlay = true;
        }

        public void SetSource(string path) 
        {
            Media.Source = new Uri(path,UriKind.Relative);
            NLogger.Debug($"Media source :{ Media.Source }");
        }

        private string ConvertTime(double time) 
        {
            TimeSpan ts = new TimeSpan(0, 0, Convert.ToInt32(time));
            return $"{ts.Hours}:{ts.Minutes}:{ts.Seconds}";
        }
    }
}
