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

namespace DB_App
{
    /// <summary>
    /// Interaction logic for Dodaj_podanie.xaml
    /// </summary>
    public partial class Dodaj_podanie : Window
    {
        public Dodaj_podanie()
        {

            InitializeComponent();
            this.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var entity = new kadryEntities2())
            {
                DateTime data = DateTime.Today;
                try
                {
                    var podanie = new Podania
                    {
                        idPo = entity.Podania.Max(u => u.idPo + 1),
                        idO = Convert.ToInt32(idOferty.Text),
                        dataZlozPo = data,
                        imiePo = Imie.Text,
                        nazwiskoPo = Nazwisko.Text,
                        miasto = Miasto.Text,
                        adres = adres.Text,
                        wyksztalceniePo = Wyksztalcenie.Text,
                        dataUrPo = DataUr.SelectedDate


                    };
                    entity.Podania.Add(podanie);
                }
                catch (Exception)
                {
                    MessageBox.Show("Podano błędne dane");
                }
            }
        }
    }
}
