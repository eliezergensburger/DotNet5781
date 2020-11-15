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
using Targil02_Tal_DotNetLab;

namespace Tragil3A_Mivchar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Bus> buslines;

        public MainWindow()
        {
            InitializeComponent();
            initBuses();

            cbBusLines.ItemsSource = buslines;
            cbBusLines.DisplayMemberPath = "Mispar";
            cbBusLines.SelectedIndex = 0;
        }

        private void initBuses()
        {
            buslines = new List<Bus>()
        {
            new Bus { Mispar =39 , StartYear= DateTime.Now ,Area = Zone.JERUSALEM},
            new Bus { Mispar =1 , StartYear= DateTime.Now,Area = Zone.JERUSALEM},
           new Bus { Mispar =10 , StartYear= DateTime.Now,Area = Zone.GENERAL},
           new Bus { Mispar =400 , StartYear= DateTime.Now.AddYears(-1),Area = Zone.CENTER}

        };
        }
    }
}
