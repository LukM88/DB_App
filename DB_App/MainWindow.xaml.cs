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
            var x = myGrid.GetLocalValueEnumerator().ToString();
            Console.WriteLine(x);
           /* using (var entity=new kadryEntities2())
            {
                var user = entity.AppUsers.Where(x => x.login == login && x.password == haslo && (x.Role == "m" || x.Role == "a")).FirstOrDefault();

                switch (box.SelectedItem.ToString())
                {
                    case "Dzialy":
                        if (user != null)
                        {
                            entity.Dzialy. = x.;
                        }
                        else
                        {
                            MessageBox.Show("Nie posiadasz uprawnień do tej operacji");

                        }
                        break;
                    case "Stanowiska":
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
                    case "Oferty":
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
                    case "stan_dzial":
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
            }*/
        }

        private void MyGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            if(myGrid.CurrentItem != null)
            {
                using (var entity= new kadryEntities2())
                {
                    DataGridCellInfo wiersz =(DataGridCellInfo) myGrid.CurrentCell;
                    Console.WriteLine(wiersz.ToString());
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

