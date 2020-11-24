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
using System.Windows.Shapes;

namespace Targil3b_Alef
{
    /// <summary>
    /// Interaction logic for AddBusWindow.xaml
    /// </summary>
    public partial class AddBusWindow : Window
    {
        private Bus newbus = new Bus();
        public Bus Bus => newbus;
//        public Bus Bus { get { return newbus; } }
        public AddBusWindow()
        {
            InitializeComponent();
            this.busGrid.DataContext = newbus;
        }
       
     }
}
