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

namespace TRPGTools
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            addContentControl.Content = new UC_SmartDice();
            tb_curTools.Text = "TRPG智能骰子";
        }
        #endregion

        #region "关于"菜单处理方法
        private void About_Click(object sender, RoutedEventArgs e)
        {
            //创建"关于"对话框对象
            WndAbout wnd = new WndAbout();
            //设置新建的关于窗体属于当前窗体
            wnd.Owner = this;
            //用模式对话框形式显示"关于"对话框
            wnd.ShowDialog();
        }
        #endregion

        #region 退出菜单事件处理方法
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            //关闭程序

            //退出提示
            if (MessageBox.Show("你真的要退出应用程序吗？",
            "提示", MessageBoxButton.YesNo,
            MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
    }
}
