using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace WPFSamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 rendeles = new Window1();
            // form megnyitása rendes ablakként
            // enged fókuszt váltani
            //rendeles.Show();

            // form megnyitása párbeszéd ablakként
            // nem enged fókuszt váltani
            rendeles.ShowDialog();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
