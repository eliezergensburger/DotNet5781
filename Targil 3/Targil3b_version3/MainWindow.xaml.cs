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

namespace Targil3b_version3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<User> items = new List<User>();
            items.Add(new User() { Name = "John Doe", Age = 42 });
            items.Add(new User() { Name = "Jane Doe", Age = 39 });
            items.Add(new User() { Name = "Sammy Doe", Age = 13 });
            items.Add(new User() { Name = "Donna Doe", Age = 13 });
            lvUsers.ItemsSource = items;

         }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumn gridView = (GridViewColumn)(sender as Button).Parent;
            int x = 3;
            int y = 10;
            GridView gd = GetParent((Visual)sender);
            MessageBox.Show(gd == null ? "Empty" : gd.Columns[0]);
        }
       

        private GridView GetParent(Visual v)
        {
            while (v != null)
            {
                v = VisualTreeHelper.GetParent(v) as Visual;
                if (v is GridView)
                    break;
            }
            return v as GridView;
        }

    }
    public class User
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
