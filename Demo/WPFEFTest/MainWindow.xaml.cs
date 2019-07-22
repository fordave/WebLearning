using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WPFEFTest.models;
namespace WPFEFTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private DemoDbContext demoDbContext;
        public MainWindow()
        {
            InitializeComponent();
            demoDbContext = new DemoDbContext();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
           // UpdateDataGrid();
            var tt = new Model1().BaseAreas.AsNoTracking().Select(s=> s).ToArray();
            //var tt = new Model1().BaseAreas.SqlQuery("select * from [dbo].BaseArea").ToArray();
            //var tt = new Model1().Database.SqlQuery<BaseArea>("select * from [dbo].BaseArea").ToArray();
            datagrid.ItemsSource = tt;
        }

        private void UpdateDataGrid()
        {
            var users = (from user in demoDbContext.Users
                         orderby user.Id
                         select user).ToList();
            //datagrid.ItemsSource = null;
            datagrid.ItemsSource = users;
        }

        private void Add()
        {
            demoDbContext.Users.Add(new User { UserName = "test", UserPwd = "dave" });
            demoDbContext.SaveChanges();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(sender is Button button))
                return;

            switch (button.Name)
            {
                case "add":
                    Add();
                    break;
                case "select":
                    UpdateDataGrid();
                    break;
                case "update":

                    break;
                case "remove":
                    if (!(datagrid.SelectedItem is User user))
                        return;
                    demoDbContext.Users.Remove(user);
                    demoDbContext.SaveChanges();
                    UpdateDataGrid();
                    break;
                default:
                    break;
            }

        }



        private void Datagrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (!(e.Row.Item is User user))
                return;
            demoDbContext.SaveChanges();
        }

        private void Datagrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (!(e.Row.Item is User user))
                return;
            if (!(e.Column is DataGridTextColumn gridTextColumn))
                return;
            if (!(gridTextColumn.Header is string header))
                return;
            if (!(e.EditingElement is TextBox text))
                return;

            var type = user.GetType();
            foreach (var item in type.GetProperties())
                if (item.Name != "Id" && item.Name == header)
                    item.SetValue(user, text.Text);
           
            var result = demoDbContext.Users.SingleOrDefault(b => b.Id == user.Id);
            if (result != null)
                demoDbContext.Entry(result).CurrentValues.SetValues(result);
        }
    }
}
