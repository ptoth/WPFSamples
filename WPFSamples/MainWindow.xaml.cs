using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    public partial class MainWindow : Window
    {

        public string SzulEvRegi(string MSzamBemenet)
        {
            string valasz = "";
            if (int.Parse(MSzamBemenet) == 1) {valasz = "Régi szabály: Férfi, magyar, 1900-1997 között született.";}
            if (int.Parse(MSzamBemenet) == 2) {valasz = "Régi szabály: Nő, magyar, 1900-1997 között született.";}
            if (int.Parse(MSzamBemenet) == 3) {valasz = "Régi szabály: Férfi, magyar, 1900 előtt született.";}
            if (int.Parse(MSzamBemenet) == 4) {valasz = "Régi szabály: Nő, magyar, 1900 előtt született.";}
            if (int.Parse(MSzamBemenet) == 5) {valasz = "Régi szabály: Férfi, nem magyar, 1900-1997 között született.";}
            if (int.Parse(MSzamBemenet) == 6) {valasz = "Régi szabály: Nő, nem magyar, 1900-1997 között született.";}
            if (int.Parse(MSzamBemenet) == 7) {valasz = "Régi szabály: Férfi, nem magyar, 1900 előtt született.";}
            if (int.Parse(MSzamBemenet) == 8) {valasz = "Régi szabály: Nő, nem magyar, 1900 előtt született.";}
            return valasz;
        }


        public string SzulEvUj(string MSzamBemenet)
        {
            string valasz = "";
            if (int.Parse(MSzamBemenet) == 1) {valasz = "Új szabály: Férfi, 1900 után született."; }
            if (int.Parse(MSzamBemenet) == 2) {valasz = "Új szabály: Nő, 1900 után született."; }
            if (int.Parse(MSzamBemenet) == 3) {valasz = "Új szabály: Férfi, 1900 előtt vagy 2000 után született."; }
            if (int.Parse(MSzamBemenet) == 4) {valasz = "Új szabály: Nő, 1900 előtt vagy 2000 után született."; }
            if (int.Parse(MSzamBemenet) == 5) {valasz = "Új szabály: Férfi, nem magyar, 1900 után született."; }
            if (int.Parse(MSzamBemenet) == 6) {valasz = "Új szabály: Nő, nem magyar, 1900 után született."; }
            if (int.Parse(MSzamBemenet) == 7) {valasz = "Új szabály: Férfi, nem magyar, 1900 előtt született."; }
            if (int.Parse(MSzamBemenet) == 8) {valasz = "Új szabály: Nő, nem magyar, 1900 után született."; }
            return valasz;
        }

        public bool SzamotEllenorizRegi(string szemelyiAzonosito) 
        {
            int ellenorzes = 0;
            for (int i = 0; i < szemelyiAzonosito.Length - 1; i++)
            {
                ellenorzes += int.Parse(szemelyiAzonosito[i].ToString()) * (i + 1);
            }
            int Kmod11 = ellenorzes % 11;

            if (Kmod11 == int.Parse(szemelyiAzonosito[10].ToString()))
            {
                return true;
            } else
            {
                return false;
            }

        }

        public bool SzamotEllenorizUj(string szemelyiAzonosito) 
        {
            int ellenorzes = 0;
            for (int i = 0; i < szemelyiAzonosito.Length - 1; i++)
            {
                ellenorzes += int.Parse(szemelyiAzonosito[i].ToString()) * ((szemelyiAzonosito.Length - 1) - i);
            }
            int Kmod11 = ellenorzes % 11;

            if (Kmod11 == int.Parse(szemelyiAzonosito[10].ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string inputAdat = TextBoxInput.Text;
            string Mszam = inputAdat.Substring(0, 1);
            string EEHHNNszam = inputAdat.Substring(1, 6);
            string EvSzam = EEHHNNszam.Substring(0, 2);
            string HonapSzam = EEHHNNszam.Substring(2, 2);
            string NapSzam = EEHHNNszam.Substring(4, 2);
            string SSSszam = inputAdat.Substring(7, 3);
            string Kszam = inputAdat.Substring(10);

            string SzulEvEredmeny = "";
            string EllenorzesEredmeny = "";


            if (TextBoxInput.Text.Length > 11 || TextBoxInput.Text.Length < 11 || int.Parse(HonapSzam) > 12 || int.Parse(NapSzam) > 31)
            {
                MessageBox.Show("Hibás bemenet, kérem, hogy pontosan 11 karakter adjon meg, figyeljen a dátumra!");
            }
            else
            {                
                MessageBox.Show("Személyi szám substr: " + inputAdat + " = " + Mszam +" "+ EEHHNNszam 
                        +" darabolva: "+ EvSzam + " " + HonapSzam + " " + NapSzam + " " + SSSszam + " " + Kszam);


                if (int.Parse(EEHHNNszam.Substring(0,2)) < 97 && int.Parse(EEHHNNszam.Substring(0, 2)) > 50)
                {
                    SzulEvEredmeny = SzulEvRegi(Mszam);
                }
                else
                {
                    SzulEvEredmeny = SzulEvUj(Mszam);
                }
                
                if (int.Parse(EEHHNNszam.Substring(0, 2)) < 97 && int.Parse(EEHHNNszam.Substring(0, 2)) > 50)
                {
                    if (SzamotEllenorizRegi(inputAdat))
                    {
                        MessageBox.Show(SzamotEllenorizRegi(inputAdat).ToString());
                        EllenorzesEredmeny = "Az utolsó számjegyre a régi szabály vonatkozik, a megadott érték helyes!";
                    } 
                    else
                    {
                        MessageBox.Show(SzamotEllenorizRegi(inputAdat).ToString());
                        EllenorzesEredmeny = "Az utolsó számjegyre a régi szabály vonatkozik, a megadott érték nem helyes!";
                    }
                    
                }
                else
                {
                    if (SzamotEllenorizUj(inputAdat))
                    {
                        EllenorzesEredmeny = "Az utolsó számjegyre a új szabály vonatkozik, a megadott érték helyes!";
                    }
                    else
                    {
                        EllenorzesEredmeny = "Az utolsó számjegyre a új szabály vonatkozik, a megadott érték nem helyes!";
                    }
                }

                MessageBox.Show("Az ellenőrzés eredménye: \n" +
                    SzulEvEredmeny + "\n" +
                    EllenorzesEredmeny, "Címke"
                    ); ;
            }
        }
    }
}
