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

namespace DB_App
{
    /// <summary>
    /// Interaction logic for Dodawanie.xaml
    /// </summary>
    public partial class Dodawanie_Prac : Window
    {
        private String log, has;
        public Dodawanie_Prac(String log,String has)
        {
            InitializeComponent();
            this.log = log;
            this.has = has;
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Conector con = new Conector(log, has);
            con.InsertPrac(imie.Text, nazwisko.Text, miasto.Text, adres.Text, placa.Text, nr_tel.Text);
            this.Close();
        }
    }
}
