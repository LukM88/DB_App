using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String login, haslo;

        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
             new Dodaj(login,haslo);
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Usun a = new Usun(login, haslo);
            a.Show();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (var entity = new kadryEntities2())
            {
                var user = entity.AppUsers.Where(x => x.login == login && x.password == haslo && (x.Role == "m" || x.Role == "a")).FirstOrDefault();



                switch (box.SelectedItem.ToString())
                {
                    case "Dzialy":
                        var tab1 = entity.Dzialy.ToArray();
                        myGrid.DataContext = tab1;
                        break;
                    case "Stanowiska":

                        var tab3 = entity.Stanowiska.ToArray();
                        myGrid.DataContext = tab3;
                        break;

                    case "Oferty":
                        var tab2 = entity.Oferty.ToArray();
                        myGrid.DataContext = tab2;
                        break;
                    case "Podania":
                        if (user != null)
                        {
                            var tab4 = entity.Podania.ToArray();
                            myGrid.DataContext = tab4;
                        }
                        else
                        {
                            MessageBox.Show("Nie posiadasz uprawnień do tej operacji");
                        }
                       
                        break;
                    case "Rozmowy":
                        var tab6 = entity.Rozmowy.ToArray();
                        myGrid.DataContext = tab6;
                        break;
                    case "stan_dzial":
                        var tab5 = entity.stan_dzial.ToArray();
                        myGrid.DataContext = tab5;
                        break;
                    case "AppUsers":
                        if (user != null)
                        {
                            var tab8 = entity.AppUsers.ToArray();
                            myGrid.DataContext = tab8;
                        }
                        else
                        {
                            MessageBox.Show("Nie posiadasz uprawnień do tej operacji");

                        }
                        
                        break;
                    default:
                        if (user != null)
                        {
                            var tab7 = entity.Pracownicy.ToArray();
                            myGrid.DataContext = tab7;
                        }
                        else
                        {
                            MessageBox.Show("Nie posiadasz uprawnień do tej operacji");
                        }
                        
                        break;
                }
            }
               
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            using (var entity = new kadryEntities2())
            {
                if (box.SelectedIndex != -1)
                {
                    var user = entity.AppUsers.Where(x => x.login == login && x.password == haslo && (x.Role == "m" || x.Role == "a")).FirstOrDefault();
                    if (user != null)
                    {

                        switch (box.SelectedItem.ToString())
                        {

                            case "Dzialy":
                                var zmienna = (Dzialy[])myGrid.DataContext;
                                for (int i = 0; i < zmienna.Count(); i++)
                                {
                                    if (user != null)
                                    {
                                        entity.ModDzialy(zmienna[i].idD, zmienna[i].nazwaD, zmienna[i].miastoD, zmienna[i].adresD);

                                    }
                                    else
                                    {
                                        MessageBox.Show("Nie posiadasz uprawnień do tej operacji");
                                        break;
                                    }
                                }
                                entity.SaveChanges();
                                break;
                            case "Stanowiska":
                                var zmienna1 = (Stanowiska[])myGrid.DataContext;
                                for (int i = 0; i < zmienna1.Count(); i++)
                                {
                                    if (user != null)
                                    {
                                        entity.ModStano(zmienna1[i].idS, zmienna1[i].nazwa);

                                    }
                                    else
                                    {
                                        MessageBox.Show("Nie posiadasz uprawnień do tej operacji");
                                        break;
                                    }
                                }
                                entity.SaveChanges();
                                break;
                            case "Oferty":
                                var zmienna2 = (Oferty[])myGrid.DataContext;
                                for (int i = 0; i < zmienna2.Count(); i++)
                                {
                                    if (user != null)
                                    {
                                        entity.ModOferty(zmienna2[i].idO, zmienna2[i].dataWystaw);

                                    }
                                    else
                                    {
                                        MessageBox.Show("Nie posiadasz uprawnień do tej operacji");
                                        break;
                                    }
                                }
                                entity.SaveChanges();
                                break;
                            case "Podania":
                                var zmienna3 = (Podania[])myGrid.DataContext;
                                for (int i = 0; i < zmienna3.Count(); i++)
                                {
                                    if (user != null)
                                    {
                                        entity.ModPodania(zmienna3[i].idPo, zmienna3[i].idR, zmienna3[i].idO, zmienna3[i].imiePo, zmienna3[i].nazwiskoPo, zmienna3[i].miasto, zmienna3[i].adres, zmienna3[i].dataUrPo, zmienna3[i].wyksztalceniePo, zmienna3[i].dataZlozPo);

                                    }
                                    else
                                    {
                                        MessageBox.Show("Nie posiadasz uprawnień do tej operacji");
                                        break;
                                    }
                                }
                                entity.SaveChanges();
                                break;
                            case "Rozmowy":
                                var zmienna4 = (Rozmowy[])myGrid.DataContext;
                                for (int i = 0; i < zmienna4.Count(); i++)
                                {
                                    if (user != null)
                                    {
                                        entity.ModRozmowy(zmienna4[i].idR, zmienna4[i].idP, zmienna4[i].idPo, zmienna4[i].dataRozmowy);

                                    }
                                    else
                                    {
                                        MessageBox.Show("Nie posiadasz uprawnień do tej operacji");
                                        break;
                                    }
                                }
                                entity.SaveChanges();
                                break;
                            case "AppUsers":
                                var zmienna5 = (AppUsers[])myGrid.DataContext;
                                for (int i = 0; i < zmienna5.Count(); i++)
                                {
                                    if (user != null)
                                    {
                                        entity.ModAppUsers(zmienna5[i].uId, zmienna5[i].login, zmienna5[i].password, zmienna5[i].Role);

                                    }
                                    else
                                    {
                                        MessageBox.Show("Nie posiadasz uprawnień do tej operacji");
                                        break;
                                    }
                                }
                                entity.SaveChanges();
                                break;
                            case "Pracownicy":
                                var zmienna6 = (Pracownicy[])myGrid.DataContext;
                                for (int i = 0; i < zmienna6.Count(); i++)
                                {
                                    if (user != null)
                                    {
                                        entity.ModPracownicy(zmienna6[i].idP, zmienna6[i].imieP, zmienna6[i].nazwiskoP, zmienna6[i].miastoP, zmienna6[i].adresP, zmienna6[i].nrTelP, zmienna6[i].placaP);

                                    }
                                    else
                                    {
                                        MessageBox.Show("Nie posiadasz uprawnień do tej operacji");
                                        break;
                                    }
                                }
                                entity.SaveChanges();

                                break;
                            default:

                                MessageBox.Show("Błąd modyfikacji");
                                break;



                        }
                        myGrid.UpdateLayout();
                    }
                    else
                    {
                        MessageBox.Show("Nie posiadasz uprawnień do tej operacji");
                    }

                }
                else
                {
                    MessageBox.Show("Wybierz tabele");
                }
                /* using (var entity=new kadryEntities2())
                 {
                     
                     
                 }*/
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            myGrid.UpdateLayout();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            using (var entity = new kadryEntities2())
            {
                var user = entity.AppUsers.Where(x => x.login == login && x.password == haslo && (x.Role == "m" || x.Role == "a")).FirstOrDefault();
                if (user != null)
                {
                    try
                    {
                        String input = Microsoft.VisualBasic.Interaction.InputBox("Podaj wartość",
                                             "Podaj Id Działu",
                                             "",
                                             -1, -1);
                        myGrid.DataContext = entity.pracownicyDzialu(Convert.ToInt32(input)).ToArray();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Podano nieprawidłową wartość");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Nie masz uprawnień do tenj  funkcji");
                }
            }
               
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            using (var entity = new kadryEntities2())
            {
                var user = entity.AppUsers.Where(x => x.login == login && x.password == haslo && (x.Role == "m" || x.Role == "a")).FirstOrDefault();
                if (user != null)
                {
                    
                    myGrid.DataContext = entity.kierownicy().ToArray();
                   

                }
                else
                {
                    MessageBox.Show("Nie masz uprawnień do tenj  funkcji");
                }
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            using (var entity = new kadryEntities2())
            {
                myGrid.DataContext = entity.WolneEtaty().ToArray();
            }
               
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            using (var entity = new kadryEntities2())
            {
                var user = entity.AppUsers.Where(x => x.login == login && x.password == haslo && (x.Role == "m" || x.Role == "a")).FirstOrDefault();
                if (user != null)
                {
                    try
                    {
                        String input = Microsoft.VisualBasic.Interaction.InputBox("Podaj wartość",
                                             "Podaj datę która cię interesuje",
                                             "RRRR-mm-dd",
                                             -1, -1);
                        myGrid.DataContext = entity.rozmowyPerDzien(Convert.ToDateTime(input)).ToArray();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Podano nieprawidłową wartość");
                    }

                }
                else
                {
                    MessageBox.Show("Nie masz uprawnień do tenj  funkcji");
                }
            }
        }

        public MainWindow(String uid,String password)
        {
            InitializeComponent();
            this.login = uid;
            this.haslo = password;
            
            using (var entity = new kadryEntities2())
            {
                var tab = entity.TABELE.ToArray();
                List<String> tabele=new List<string>();
                for(int i = 0; i < tab.Length; i++)
                {
                    tabele.Add(tab[i].TABLE_NAME.ToString());
                }
                box.ItemsSource = tabele;
                var tab2 = entity.Oferty.ToArray();
                myGrid.DataContext = tab2;

            }

           
        }
    }
}

