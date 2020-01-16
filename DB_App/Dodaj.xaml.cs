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
    /// Interaction logic for DodajPodanie.xaml
    /// </summary>
    public partial class Dodaj : Window
    {
        private String log, has;
        public Dodaj(String log, String has)
        {
            
            InitializeComponent();
            this.log = log;
            this.has = has;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime dateOnly1,dateOnly2;
            
            DateTime date1 = DateTime.Today;
            dateOnly2 = date1.Date;
            if (picker.SelectedDate.Equals(null))
            {
                dateOnly1 = dateOnly2;
            }
            else
            {
                dateOnly1 = (DateTime)picker.SelectedDate;
                Console.WriteLine(dateOnly1.ToString("yyyy-MM-dd"));
            }
           // Conector con = new Conector(log, has);
           // con.InsertKan(imie.Text, nazwisko.Text,dateOnly1.ToString("yyyy-MM-dd"), dateOnly2.ToString("yyyy-MM-dd"),wyksztalcenie.Text, miasto.Text, adres.Text, nr_tel.Text,id_oferty.Text,id_stan.Text);
            this.Close();
        }
    }
}
