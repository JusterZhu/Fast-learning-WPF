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

        public ICommand LoingCommand { get; set; }

        public bool IsLogin { get; set; }

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
            LoingCommand = new RelayCommand(LoginAction);
            Account = "root";
        }

        private void LoginAction()
        {
            if (Account == "root" && PassWrold == "123")
            {
                IsLogin = true;
                MessageBox.Show("登录成功！");
            }
            else
            {
                IsLogin = false;
                MessageBox.Show("登录失败！");
            }
        }
    }
}
