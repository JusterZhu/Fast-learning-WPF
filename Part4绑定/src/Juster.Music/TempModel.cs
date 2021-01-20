using Juster.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juster.Music
{
    public class TempModel
    {
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


        public TempModel() 
        {
            Account = "root";
            LoginTypes = new List<string>();
            LoginTypes.Add("手机号登录");
            LoginTypes.Add("账号密码登录");
            LoginTypes.Add("二维码登录");
        }
    }
}
