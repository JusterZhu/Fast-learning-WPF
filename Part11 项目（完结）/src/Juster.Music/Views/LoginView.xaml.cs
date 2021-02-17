using Juster.Music.ViewModels;
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
using System.Windows.Shapes;

namespace Juster.Music.Views
{
    /// <summary>
    /// LoginView.xaml 的交互逻辑
    /// </summary>
    public partial class LoginView : Window
    {
        private LoginViewModel _vm;

        public LoginView()
        {
            InitializeComponent();
            _vm = new LoginViewModel();
            DataContext = _vm;
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            _vm.LoingCommand.Execute(null);
            if (_vm.IsLogin)
            {
                this.Close();
            }
        }
    }
}
