using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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
            this.Closing += MainWindow_Closing;

            // List<User> items = new List<User>();
            ObservableCollection<User> items = new ObservableCollection<User>();
            items.Add(new User() { Name = "John Doe", Age = 42 });
            items.Add(new User() { Name = "Jane Doe", Age = 39 });
            items.Add(new User() { Name = "Sammy Doe", Age = 13 });
            items.Add(new User() { Name = "Donna Doe", Age = 13 });
            lvUsers.ItemsSource = items;
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void Tidluk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Button btn = e.Result as Button;
            btn.IsEnabled = true;
            btn.Background = Brushes.Green;
   //         throw new NotImplementedException();
        }

        private void Tidluk_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Object> lst = (List<object>)e.Argument;

            int value = (int)lst[0];    //3000
            Thread.Sleep(value);

            //idkun delek acharei hamiluy
            User currentUser = (User)lst[1];
            currentUser.Age += 10;

            e.Result = lst[2];          //btn
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            User currentuser = btn.DataContext as User;

            btn.IsEnabled = false;

            tidluk(currentuser, 3000, btn);
        }

        private void tidluk(User lineData, int time, Button btn)
        {
            List<Object> lst = new List<object> { time, lineData, btn };

            BackgroundWorker tidluk = new BackgroundWorker();
            tidluk.DoWork += Tidluk_DoWork;
            tidluk.RunWorkerCompleted += Tidluk_RunWorkerCompleted;

            tidluk.RunWorkerAsync(lst);
        } 
    }

    public class User : INotifyPropertyChanged
    {
        private string name;
        private int age;

        public string Name 
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        protected void OnPropertyChanged(String propertyName)
        {
            //if (PropertyChanged != null)
            //{
            //    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            //}
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int Age 
        {
            get => age;
            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
