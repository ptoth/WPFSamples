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

namespace WPFSamples
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            this.textBox1.IsEnabled = false;
            this.textBox2.IsEnabled = false;
            this.textBox3.IsEnabled = false;
            this.textBox4.IsEnabled = false;
            this.textBox5.IsEnabled = false;

            this.textBox1.Text = "0";
            this.textBox2.Text = "0";
            this.textBox3.Text = "0";
            this.textBox4.Text = "0";
            this.textBox5.Text = "0";

        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            this.textBox1.IsEnabled = true;
        }

        private void checkBox2_Checked(object sender, RoutedEventArgs e)
        {
            this.textBox2.IsEnabled = true;
        }

        private void checkBox3_Checked(object sender, RoutedEventArgs e)
        {
            this.textBox3.IsEnabled = true;
        }

        private void checkBox4_Checked(object sender, RoutedEventArgs e)
        {
            this.textBox4.IsEnabled = true;
        }

        private void checkBox5_Checked(object sender, RoutedEventArgs e)
        {
            this.textBox5.IsEnabled = true;
        }

        private void checkBox1_Unchecked(object sender, RoutedEventArgs e)
        {
            this.textBox1.IsEnabled = false;
            this.textBox1.Text = "0";
        }

        private void checkBox2_Unchecked(object sender, RoutedEventArgs e)
        {
            this.textBox2.IsEnabled = false;
            this.textBox2.Text = "0";
        }

        private void checkBox3_Unchecked(object sender, RoutedEventArgs e)
        {
            this.textBox3.IsEnabled = false;
            this.textBox3.Text = "0";
        }

        private void checkBox4_Unchecked(object sender, RoutedEventArgs e)
        {
            this.textBox4.IsEnabled = false;
            this.textBox4.Text = "0";
        }

        private void checkBox5_Unchecked(object sender, RoutedEventArgs e)
        {
            this.textBox5.IsEnabled = false;
            this.textBox5.Text = "0";
        }

        private void btnRendel_Click(object sender, RoutedEventArgs e)
        {
            int somloiDarab = 0;
            int rakocziDarab = 0;
            int csokitortaDarab = 0;
            int marcipanDarab = 0;
            int eszterhazyDarab = 0;

            // parsing inputs:
            if (textBox1.IsEnabled == true)
            {
                somloiDarab = Int32.Parse(textBox1.Text.ToString());
            }

            if (textBox2.IsEnabled == true)
            {
                rakocziDarab = Int32.Parse(textBox2.Text.ToString());
            }

            if (textBox3.IsEnabled == true)
            {
                csokitortaDarab = Int32.Parse(textBox3.Text.ToString());
            }

            if (textBox4.IsEnabled == true)
            {
                marcipanDarab = Int32.Parse(textBox4.Text.ToString());
            }

            if (textBox5.IsEnabled == true)
            {
                eszterhazyDarab = Int32.Parse(textBox5.Text.ToString());
            }

            string rendeles = "";
            rendeles += "Somlói galuska    : " + somloiDarab + "\n";
            rendeles += "Rákóczi túrós     : " + rakocziDarab + "\n";
            rendeles += "Csoki torta       : " + csokitortaDarab + "\n";
            rendeles += "Marcipán alagút   : " + marcipanDarab + "\n";
            rendeles += "Eszterházy szelet : " + eszterhazyDarab + "\n";

            MessageBox.Show(rendeles);
            
        }
    }
}
