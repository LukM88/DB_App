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
        private String log, has,role;

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (var entity = new kadryEntities())
            {
                
                switch (box.SelectedItem.ToString())
                {
                    case "Dzialy":
                        var tab1 = entity.Dzialy;
                        System.Console.WriteLine(tab1.ToString());
                        System.Console.WriteLine(numberOfReps(tab1.ToString(),"S"));
                        break;
                    case "Stanowiska":
                        var tab3 = entity.Stanowiska.ToArray();
                       
                        break;

                    case "Oferty":
                        var tab2 = entity.Oferty.ToArray();
                        
                        break;
                    case "Podania":
                        var tab4 = entity.Podania.ToArray();
                        
                        break;
                    case "Rozmowy":
                        var tab6 = entity.Rozmowy.ToArray();
                        
                        break;
                    case "stan_dzial":
                        var tab5 = entity.stan_dzial.ToArray();
                        
                        break;
                    case "stan_prac":
                        var tab0 = entity.Database.SqlQuery<String>("SELECT * FROM stan_prac");
                       
                        break;
                    default:
                        var tab7 = entity.Pracownicy.ToArray();
                       
                        break;
                }
            }
        }

        public Dodaj(String log, String has)
        {
            InitializeComponent();
            Console.WriteLine("FU");
            this.log = log;
            this.has = has;
            using (var entity = new kadryEntities())
            {
                Console.WriteLine("FU");
                var user = entity.AppUsers.Where(x => x.login == log && x.password == has && (x.Role == "m" || x.Role=="a")).FirstOrDefault();
                if (user != null)
                {
                    this.role = user.Role;
                    this.Show();

                    
                        var tab = entity.TABELE.ToArray();
                        List<String> tabele = new List<string>();
                        for (int i = 0; i < tab.Length; i++)
                        {
                            tabele.Add(tab[i].TABLE_NAME.ToString());
                        }
                        box.ItemsSource = tabele;
                        
                        
                }
                else
                {
                    MessageBox.Show("Nie posiadasz uprawnień do tej operacji");
                    this.Close();
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {   

            //DateTime dateOnly1,dateOnly2;
            using (var entity = new kadryEntities())
            {
                var id = entity.AppUsers.Max(u => u.uId);
                var user = new AppUser { uId = (id+1), login = "Andrzej", password = "", Role = "a" };

                
                entity.AppUsers.Add(user);
                entity.SaveChanges();
            }
           /*     DateTime date1 = DateTime.Today;
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
           */// con.InsertKan(imie.Text, nazwisko.Text,dateOnly1.ToString("yyyy-MM-dd"), dateOnly2.ToString("yyyy-MM-dd"),wyksztalcenie.Text, miasto.Text, adres.Text, nr_tel.Text,id_oferty.Text,id_stan.Text);
            this.Close();
        }
        private int numberOfReps(String tekst,String znak)
        {
            int count=0;
            for(int i = 0; i > tekst.Length; i++)
            {
                if ((i + znak.Length) < tekst.Length)
                {
                    if (tekst.Substring(i, znak.Length).Equals(znak))
                    {
                        count++;
                    }
                }
                
            }
            return count;
        }
    }
}
