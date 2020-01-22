using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace DB_App
{
    /// <summary>
    /// Interaction logic for Usun.xaml
    /// </summary>
    public partial class Usun : Window
    {   
        String a, b,tab;
        
        public Usun(String log,String pwd)
        {
            InitializeComponent();
            this.a = log;
            this.b = pwd;
            using (var entity = new kadryEntities2())
            {
                var user = entity.AppUsers.Where(x => x.login == a && x.password == b && (x.Role == "m" || x.Role == "a")).FirstOrDefault();
                if (user != null)
                {
                    var tab = entity.TABELE.ToArray();
                    List<String> tabele = new List<string>();
                    for (int i = 0; i < tab.Length; i++)
                    {
                        tabele.Add(tab[i].TABLE_NAME.ToString());
                    }
                    boxTabel.ItemsSource = tabele;
                }
                else
                {
                    MessageBox.Show("Nie masz uprawnień do usuwania rekordów");
                    this.Close();
                }
               

            }
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var entity = new kadryEntities2())
            {
                switch (boxTabel.SelectedItem.ToString())
                {
                    case "Dzialy":
                        entity.DelDzial(Convert.ToInt32(id.Text));
                        
                        break;
                    case "Stanowiska":

                        entity.StanDel(Convert.ToInt32(id.Text));
                        break;

                    case "Oferty":
                        entity.OfertyDel(Convert.ToInt32(id.Text));
                        break;
                    case "Podania":

                        entity.PodaniaDel(Convert.ToInt32(id.Text));


                        break;
                    case "Rozmowy":
                        entity.RozmowyDel(Convert.ToInt32(id.Text));
                        break;
                    case "stan_dzial":
                        entity.StanDzialDel(Convert.ToInt32(id.Text), Convert.ToInt32(id2.Text));
                        break;
                    case "AppUsers":

                        entity.AppUsDel(Convert.ToInt32(id.Text));


                        break;
                    default:

                        entity.PracowDel(Convert.ToInt32(id.Text));


                        break;
                }
                entity.SaveChanges();
                grid.UpdateLayout();
                MessageBox.Show("usuwanie powiodło się");
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            using (var entity = new kadryEntities2())
            {
                switch (boxTabel.SelectedItem.ToString())
                {
                    case "Dzialy":
                        var tab1 = entity.Dzialy.ToArray();
                        grid.DataContext = tab1;
                        break;
                    case "Stanowiska":

                        var tab3 = entity.Stanowiska.ToArray();
                        grid.DataContext = tab3;
                        break;

                    case "Oferty":
                        var tab2 = entity.Oferty.ToArray();
                        grid.DataContext = tab2;
                        break;
                    case "Podania":
                        
                            var tab4 = entity.Podania.ToArray();
                            grid.DataContext = tab4;
                       

                        break;
                    case "Rozmowy":
                        var tab6 = entity.Rozmowy.ToArray();
                        grid.DataContext = tab6;
                        break;
                    case "stan_dzial":
                        var tab5 = entity.stan_dzial.ToArray();
                        grid.DataContext = tab5;
                        break;
                    case "AppUsers":
                        
                            var tab8 = entity.AppUsers.ToArray();
                            grid.DataContext = tab8;
                        

                        break;
                    default:
                        
                            var tab7 = entity.Pracownicy.ToArray();
                            grid.DataContext = tab7;
                        

                        break;
                }

            }


            grid.UpdateLayout();
        }
    }
}
