using Juster.Common;
using Juster.Music.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Juster.Music.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        #region 属性字段

        public ICommand ChangeCommand { get; set; }

        public ICommand LoingCommand { get; set; }

        public ICommand CancelRemberCommand { get; set; }


        private int _color;

        public int Color
        {
            get { return _color; }
            set
            {
                _color = value;
                OnPropertyChanged("Color");
            }
        }

        private string _account;

        public string Account
        {
            get { return _account; }
            set
            {
                _account = value;
            }
        }

        private string _passwrold;

        public string PassWrold
        {
            get { return _passwrold; }
            set
            {
                _passwrold = value;
            }
        }

        private List<string> _loginTypes;

        public List<string> LoginTypes
        {
            get { return _loginTypes; }
            set { _loginTypes = value; }
        }

        #endregion

        public LoginViewModel()
        {
            ChangeCommand = new RelayCommand(ChangeAction);
            LoingCommand = new RelayCommand(LoginAction);
            CancelRemberCommand = new RelayCommand<bool>(CancelAction);
            Account = "root";
            LoginTypes = new List<string>();
            LoginTypes.Add("手机号登录");
            LoginTypes.Add("账号密码登录");
            LoginTypes.Add("二维码登录");
        }

        private void ChangeAction()
        {
            if (Color > 2)
            {
                Color = -1;
            }
            Color++;
        }

        private void CancelAction(bool obj)
        {
            MessageBox.Show($"check status { obj }");
        }

        private void LoginAction()
        {
            if (Account == "root" && PassWrold == "123")
            {
                MessageBox.Show("登录成功！");
            }
            else
            {
                MessageBox.Show("登录失败！");
            }
        }
    }
}
