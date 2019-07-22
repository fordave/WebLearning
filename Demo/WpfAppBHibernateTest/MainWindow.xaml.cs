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
using WpfAppBHibernateTest.Models;
using WpfAppBHibernateTest.Utils;

namespace WpfAppBHibernateTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var userManager = new Manager<User>();


            var user = new User() { UserName = "3643uhyrjut", UserPwd = "123453143" };

            userManager.Add(user);

            // 查询单条纪录
            // User user = userManager.GetUserByUserName("agr43");
            //Console.WriteLine(user.UserPwd);

            // 查询多条纪录
            ICollection<User> list = userManager.GetAll();
            foreach (User item in list)
            {
                Console.WriteLine(item.UserPwd+item.UserName);
            }

            // 验证登录
            //Console.WriteLine(userManager.VerifyUser("jjssag1", "4606519"));

        }
    }
}
