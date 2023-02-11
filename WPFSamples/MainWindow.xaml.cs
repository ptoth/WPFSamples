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

            btnTopLeftSideButton.Content = "";
            btnTopMidButton.Content = "";
            btnTopRightSideButton.Content = "";
            btnMidLeftSideButton.Content = "";
            btnMidMidButton.Content = "";
            btnMidRightSideButton.Content = "";
            btnBottomLeftButton.Content = "";
            btnMidBottomButton.Content = "";
            btnBottomRightButton.Content = "";
        }

        private bool IsButtonChecked(Button gomb)
        {
            if (gomb.Content.Equals("O") || gomb.Content.Equals("X"))
            { return true; }
            else 
            { return false; }
        }

        private void ellenorzes()
        {

        }


        private void btnTopLeftSideButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsButtonChecked(btnTopLeftSideButton))
            {
                MessageBox.Show("Ez a hely már foglalt!");
            }
            else
            {
                btnTopLeftSideButton.Content = "X";
            }
        }

        private void btnTopMidButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTopRightSideButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMidLeftSideButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMidMidButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMidRightSideButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBottomLeftButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMidBottomButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBottomRightButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
