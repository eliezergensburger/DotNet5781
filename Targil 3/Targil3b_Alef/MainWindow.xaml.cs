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


namespace Targil3b_Alef
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random rand = new Random(DateTime.Now.Millisecond);
        static List<Bus> buses = new List<Bus>();

        public MainWindow()
        {
            GenerateBuses(10);
            this.DataContext = buses;
            InitializeComponent();

        }

        private void GenerateBuses(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                int reg7_8 = rand.Next(7, 9);
                int regNum = getRandomRegNum(reg7_8);
                DateTime regDate = getRandomDate(reg7_8);
                //  DateTime serviceDate = getRandomDateTime(rand.Next(1, 10));
                // int serviceOdo = rand.Next(20000);
                //buses.Add(new Bus(regNum, regDate, serviceDate, serviceOdo));
                buses.Add(new Bus(regNum, regDate));
            }
        }

        private DateTime getRandomDate(int reg7_8)
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            DateTime result = start.AddDays(rand.Next(range));
            if (reg7_8 == 7)
            {
                if (result.Year > 2018)
                {
                    //fix that next time
                    result.AddYears(result.Year - 2018);
                }
            }
            else if (reg7_8 == 8)
            {
                if (result.Year < 2018)
                {
                    //fix that next time
                    result.AddYears(result.Year - 2018);
                }
            }
            return result;
        }

        /// <summary>
        /// create new DateTime from months before 
        /// with a random  day of the  month
        /// </summary>
        /// <param name="monthBefore">haw many months before today</param>
        /// <returns>new DateTime object</returns>
        private static DateTime getRandomDateTime(int monthBefore)
        {
            return DateTime.Now.AddMonths(-monthBefore).AddDays(-rand.Next(1, 30));
        }

        private int getRandomRegNum(int reg7_8)
        {
            int prefix;
            int middle;
            int suffix;
            int mispar = 0;
            switch (reg7_8)
            {
                case 7:
                    //xx-xxx-xx
                    //1200000
                    //1255500
                    //1255577
                    prefix = rand.Next(10, 100);
                    middle = rand.Next(100, 1000);
                    suffix = rand.Next(10, 100);

                    mispar += prefix * 100000;
                    mispar += middle * 100;
                    mispar += suffix;
                    break;
                case 8:
                    //xxx-xx-xxx
                    //12300000
                    //12355000
                    //12555777
                    prefix = rand.Next(100, 1000);
                    middle = rand.Next(10, 100);
                    suffix = rand.Next(100, 1000);

                    mispar += prefix * 100000;
                    mispar += middle * 1000;
                    mispar += suffix;
                    break;
                default:
                    break;
            }
            return mispar;
        }

        private void addBus(object sender, RoutedEventArgs e)
        {
            AddBusWindow window = new AddBusWindow();
            window.Show();

        }
    }
}
