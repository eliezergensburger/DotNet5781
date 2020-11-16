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

namespace Targil3a_Lev
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BusCompany busCompany;
        private BusLine currentDisplayBusLine;
        private static   Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
            busCompany = new BusCompany();
            //targil 2 itchul
            initComboBox();
        }

        private void initComboBox()
        {
            cbBusLines.ItemsSource = busCompany.BusLines;
            cbBusLines.DisplayMemberPath = "BusLineNum ";
            cbBusLines.SelectedIndex = 0;
            ShowBusLine(((BusLine)cbBusLines.SelectedItem).BusLineNum);
        }

        private void cbBusLines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowBusLine((cbBusLines.SelectedValue as BusLine).BusLineNum);
        }

        private void ShowBusLine(int busLineNum)
        {
            currentDisplayBusLine = busCompany[busLineNum];
            UpGrid.DataContext = currentDisplayBusLine;
            lbBusLineStations.DataContext = currentDisplayBusLine.Stations;
        }
    }
}
