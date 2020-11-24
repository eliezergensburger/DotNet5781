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

namespace Targil3b_version2
{
    /// <summary>
    /// Interaction logic for BusWindow.xaml
    /// </summary>
    public partial class BusWindow : Window
    {
       private Bus myBus = new Bus();
        public BusWindow()
        {
            InitializeComponent();
            this.DataContext = myBus;
        }
        public Bus NewBUS { get { return myBus; } }
      }
}
