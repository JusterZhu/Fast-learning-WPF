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
            DataContext = new TempModel();
        }

        //public MainWindow()
        //{
        //    InitializeComponent();
        //    //把命令赋值给命令源（发送者），并指定快捷键
        //    this.button1.Command = clearCmd;

        //    //指令命令目标
        //    this.button1.CommandTarget = this.textBoxA;

        //    //创建命令关联
        //    CommandBinding cb = new CommandBinding();
        //    cb.Command = this.clearCmd;    //只关注与clearCmd命令相关的事件
        //    cb.CanExecute += cb_CanExecute;
        //    cb.Executed += cb_Executed;

        //    //把命令安置在外围控件上
        //    this.stackPanel.CommandBindings.Add(cb);
        //}

        ///// <summary>
        ///// 当命令送达目标后，此方法被调用
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //void cb_Executed(object sender, ExecutedRoutedEventArgs e)
        //{
        //}

        ///// <summary>
        ///// 探测命令是否可执行时，此方法被调用
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //void cb_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        //{
        //}
    }
}
