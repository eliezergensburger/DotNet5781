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

namespace Targil3b_version2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Random rnd = new Random();
        List<Bus> buses = new List<Bus>();
         public MainWindow()
        {
            initBuses(buses);
            InitializeComponent();
            lbAllBuses.DataContext = buses;
        }

        private void initBuses(List<Bus> buses)
        {
            buses.Add(new Bus { BusLicense = 123145, Fuel = 500 });
            buses.Add(new Bus { BusLicense = 123145, Fuel = 500 });
            buses.Add(new Bus { BusLicense = 123145, Fuel = 500 });
            buses.Add(new Bus { BusLicense = 123145, Fuel = 500 });
            buses.Add(new Bus { BusLicense = 123145, Fuel = 500 });
            buses.Add(new Bus { BusLicense = 123145, Fuel = 500 });
            buses.Add(new Bus { BusLicense = 123145, Fuel = 500 });
            buses.Add(new Bus { BusLicense = 123145, Fuel = 500 });
            buses.Add(new Bus { BusLicense = 123145, Fuel = 500 });
            buses.Add(new Bus { BusLicense = 123145, Fuel = 500 });
        }

        private void btnShowBus_Click(object sender, RoutedEventArgs e)
        {
            BusWindow wnd = new BusWindow();
            wnd.Show();
        }
    }
}
