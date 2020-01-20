using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
            Stos.Children.Clear();
            List<TextBox> pola = new List<TextBox>();
            List<Label> texty = new List<Label>();
            var lista = getColTitels();
            using (var entity = new kadryEntities2())
            {
                
                switch (box.SelectedItem.ToString())
                {
                    case "Dzialy":
                        var tab1 = entity.Dzialy;
                        
                        for (int i = 0;i< numberOfReps(tab1.ToString(), "AS") - 1; i++)
                        {
                            texty.Add(new Label()
                            {
                                Height = 25,
                                Width = 100,
                                Name = "Text" + i,
                                Visibility = Visibility.Visible,
                                HorizontalAlignment = HorizontalAlignment.Left,
                                Content = lista[i]


                            });
                            pola.Add(new TextBox
                            {
                                Height = 22,
                                Width = 100,
                                Name = "TextBox" + i,
                                Visibility = Visibility.Visible,
                                HorizontalAlignment = HorizontalAlignment.Left,
                                

                        });
                            if (i > 0)
                            {
                                this.Stos.Children.Add(texty[i]);
                                this.Stos.Children.Add(pola[i]);
                            }
                            

                        }
                        
                        break;
                    case "AppUsers":
                        var tab8 = entity.Dzialy;

                        for (int i = 0; i < numberOfReps(tab8.ToString(), "AS") - 1; i++)
                        {
                            texty.Add(new Label()
                            {
                                Height = 25,
                                Width = 100,
                                Name = "Text" + i,
                                Visibility = Visibility.Visible,
                                HorizontalAlignment = HorizontalAlignment.Left,
                                Content = lista[i]


                            });
                            pola.Add(new TextBox
                            {
                                Height = 22,
                                Width = 100,
                                Name = "TextBox" + i,
                                Visibility = Visibility.Visible,
                                HorizontalAlignment = HorizontalAlignment.Left,


                            });
                            if (i > 0)
                            {
                                this.Stos.Children.Add(texty[i]);
                                this.Stos.Children.Add(pola[i]);
                            }


                        }

                        break;
                    case "Stanowiska":
                        var tab3 = entity.Stanowiska;
                       
                        for (int i = 0; i < lista.Count; i++)
                        {
                            texty.Add(new Label()
                            {
                                Height = 25,
                                Width = 100,
                                Name = "Text" + i,
                                Visibility = Visibility.Visible,
                                HorizontalAlignment = HorizontalAlignment.Left,
                                Content = lista[i]


                            });
                            pola.Add(new TextBox
                            {
                                Height = 22,
                                Width = 100,
                                Name = "TextBox" + i,
                                Visibility = Visibility.Visible,
                                HorizontalAlignment = HorizontalAlignment.Left,


                            });
                            if (i > 0)
                            {
                                this.Stos.Children.Add(texty[i]);
                                this.Stos.Children.Add(pola[i]);
                            }


                        }
                        break;

                    case "Oferty":
                        var tab2 = entity.Oferty;
                        for (int i = 0; i < lista.Count; i++)
                        {
                            texty.Add(new Label()
                            {
                                Height = 25,
                                Width = 100,
                                Name = "Text" + i,
                                Visibility = Visibility.Visible,
                                HorizontalAlignment = HorizontalAlignment.Left,
                                Content = lista[i]


                            });
                            pola.Add(new TextBox
                            {
                                Height = 22,
                                Width = 100,
                                Name = "TextBox" + i,
                                Visibility = Visibility.Visible,
                                HorizontalAlignment = HorizontalAlignment.Left,


                            });
                            if (i > 0)
                            {
                                this.Stos.Children.Add(texty[i]);
                                this.Stos.Children.Add(pola[i]);
                            }


                        }
                        break;
                    case "Podania":
                        var tab4 = entity.Podania;
                        //Console.WriteLine((numberOfReps(tab4.ToString(), "AS") - 1));
                        for (int i = 0; i < lista.Count; i++)
                        {
                            texty.Add(new Label()
                            {
                                Height = 25,
                                Width = 100,
                                Name = "Text" + i,
                                Visibility = Visibility.Visible,
                                HorizontalAlignment = HorizontalAlignment.Left,
                                Content = lista[i]


                            });
                            pola.Add(new TextBox
                            {
                                Height = 22,
                                Width = 100,
                                Name = "TextBox" + i,
                                Visibility = Visibility.Visible,
                                HorizontalAlignment = HorizontalAlignment.Left,


                            });
                            if (i > 0)
                            {
                                
                                this.Stos.Children.Add(texty[i]);
                                this.Stos.Children.Add(pola[i]);
                            }
                            

                        }
                        this.Stos.Children.Add(new ScrollBar
                        {
                            Height = Stos.Height,
                            Width = 10,
                            HorizontalAlignment = HorizontalAlignment.Right,
                            Visibility = Visibility.Visible
                        });
                        break;
                    case "Rozmowy":
                        var tab6 = entity.Rozmowy;
                        for (int i = 0; i < lista.Count; i++)
                        {
                            texty.Add(new Label()
                            {
                                Height = 25,
                                Width = 100,
                                Name = "Text" + i,
                                Visibility = Visibility.Visible,
                                HorizontalAlignment = HorizontalAlignment.Left,
                                Content = lista[i]


                            });
                            pola.Add(new TextBox
                            {
                                Height = 22,
                                Width = 100,
                                Name = "TextBox" + i,
                                Visibility = Visibility.Visible,
                                HorizontalAlignment = HorizontalAlignment.Left,


                            });
                            
                                this.Stos.Children.Add(texty[i]);
                                this.Stos.Children.Add(pola[i]);
                            


                        }
                        break;
                    case "stan_dzial":
                        var tab5 = entity.stan_dzial;
                        for (int i = 0; i < lista.Count; i++)
                        {
                            texty.Add(new Label()
                            {
                                Height = 25,
                                Width = 100,
                                Name = "Text" + i,
                                Visibility = Visibility.Visible,
                                HorizontalAlignment = HorizontalAlignment.Left,
                                Content = lista[i]


                            });
                            pola.Add(new TextBox
                            {
                                Height = 22,
                                Width = 100,
                                Name = "TextBox" + i,
                                Visibility = Visibility.Visible,
                                HorizontalAlignment = HorizontalAlignment.Left,


                            });
                            
                                this.Stos.Children.Add(texty[i]);
                                this.Stos.Children.Add(pola[i]);
                            


                        }
                        break;
                   
                    default:
                        var tab7 = entity.Pracownicy;
                        for (int i = 0; i < lista.Count; i++)
                        {
                            texty.Add(new Label()
                            {
                                Height = 25,
                                Width = 100,
                                Name = "Text" + i,
                                Visibility = Visibility.Visible,
                                HorizontalAlignment = HorizontalAlignment.Left,
                                Content = lista[i]


                            });
                            pola.Add(new TextBox
                            {
                                Height = 22,
                                Width = 100,
                                Name = "TextBox" + i,
                                Visibility = Visibility.Visible,
                                HorizontalAlignment = HorizontalAlignment.Left,


                            });
                            if (i > 0)
                            {
                                this.Stos.Children.Add(texty[i]);
                                this.Stos.Children.Add(pola[i]);
                            }


                        }
                        break;
                }
            }
        }

        public Dodaj(String log, String has)
        {
            InitializeComponent();
            this.log = log;
            this.has = has;
            using (var entity = new kadryEntities2())
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
            if (box.SelectedIndex != -1) {

                //DateTime dateOnly1,dateOnly2;
                using (var entity = new kadryEntities2())
                {
                    int id;
                    List<String> dane = new List<string>();


                    switch (box.SelectedItem.ToString())
                    {
                        case "Dzialy":
                            try { 
                            id = entity.Dzialy.Max(u => u.idD);
                    }
                            catch (Exception)
                    {
                        id = 0;
                    }
                    if (id == null)
                            {
                                id = 0;
                            }
                            for (int i = 1; i < Stos.Children.Count; i += 2)
                            {
                                dane.Add(Stos.Children[i].ToString().Substring(Stos.Children[i].ToString().IndexOf(":") + 2, Stos.Children[i].ToString().Length - Stos.Children[i].ToString().IndexOf(":") -2));

                            }
                            var user = new Dzialy { idD = (id + 1) };
                            user.nazwaD = dane[0];
                            user.miastoD = dane[1];
                            user.adresD = dane[2];
                            entity.Dzialy.Add(user);

                            break;
                        case "Stanowiska":
                            try
                            {
                                id = entity.Stanowiska.Max(u => u.idS);
                            }
                            catch (Exception)
                            {
                                id = 0;
                            }
                            
                            if (id == null)
                            {
                                id = 0;
                            }

                            for (int i = 1; i < Stos.Children.Count; i += 2)
                            {
                                dane.Add(Stos.Children[i].ToString().Substring(Stos.Children[i].ToString().IndexOf(":") + 2, Stos.Children[i].ToString().Length - Stos.Children[i].ToString().IndexOf(":") - 2));
                               
                            }
                            var user2 = new Stanowiska { idS = (id + 1) };
                            user2.nazwa = dane[0];
                            entity.Stanowiska.Add(user2);

                            break;

                        case "Oferty":
                            try
                            {
                                id = entity.Oferty.Max(u => u.idO);
                            }
                            catch (Exception)
                            {
                                id = 0;
                            }
                            for (int i = 1; i < Stos.Children.Count; i += 2)
                            {
                                dane.Add(Stos.Children[i].ToString().Substring(Stos.Children[i].ToString().IndexOf(":") +2, Stos.Children[i].ToString().Length - Stos.Children[i].ToString().IndexOf(":") - 2));

                            }
                            var user3 = new Oferty { idO = (id + 1) };
                            try
                            {
                                System.Console.WriteLine("");
                                System.Console.WriteLine(dane[0] + dane[1]);
                                System.Console.WriteLine("");
                                System.Console.WriteLine(dane[2]);
                                System.Console.WriteLine("");
                                user3.idS = Convert.ToInt32(dane[0]);
                                user3.idD = Convert.ToInt32(dane[1]);
                                user3.dataWystaw = Convert.ToDateTime(dane[2]);
                                entity.Oferty.Add(user3);
                            }
                            catch (Exception)
                            {
                                this.Close();
                            }
                            break;
                        case "AppUsers":
                            id = entity.AppUsers.Max(u => u.uId);

                           
                            for (int i = 1; i < Stos.Children.Count; i += 2)
                            {
                                dane.Add(Stos.Children[i].ToString().Substring(Stos.Children[i].ToString().IndexOf(":") + 2, Stos.Children[i].ToString().Length - Stos.Children[i].ToString().IndexOf(":") - 2));

                            }
                            var user9 = new AppUsers { uId = (id + 1) };
                            try
                            {
                                user9.login = dane[0];
                                user9.password =dane[1];
                                user9.Role = dane[2];
                                entity.AppUsers.Add(user9);
                            }
                            catch (Exception)
                            {
                                this.Close();
                            }
                            break;

                        case "Podania":
                            try
                            {
                                id = entity.Podania.Max(u => u.idPo);
                            }
                            catch (Exception)
                            {
                                id = 0;
                            }
                   

                            for (int i = 1; i < Stos.Children.Count; i += 2)
                            {
                                dane.Add(Stos.Children[i].ToString().Substring(Stos.Children[i].ToString().IndexOf(":") + 2, Stos.Children[i].ToString().Length - Stos.Children[i].ToString().IndexOf(":") - 2));

                            }
                            var user4 = new Podania { idPo = (id + 1) };
                            try
                            {
                                
                                user4.idO = Convert.ToInt32(dane[0]);
                                user4.imiePo = dane[1];
                                user4.nazwiskoPo = dane[2];
                                user4.miasto = dane[3];
                                user4.adres = dane[4];
                                user4.dataUrPo = Convert.ToDateTime(dane[5]);
                                user4.wyksztalceniePo = dane[6];
                                user4.dataZlozPo = Convert.ToDateTime(dane[7]);
                                entity.Podania.Add(user4);
                            }
                            catch (Exception)
                            {
                                this.Close();
                            }
                            break;
                        case "Rozmowy":
                            try
                            {
                                id = entity.Rozmowy.Max(u => u.idR);
                            }catch (Exception)
                            {
                                 id = 0;
                             }
                    

                            for (int i = 1; i < Stos.Children.Count; i += 2)
                            {
                                dane.Add(Stos.Children[i].ToString().Substring(Stos.Children[i].ToString().IndexOf(":") + 2, Stos.Children[i].ToString().Length - Stos.Children[i].ToString().IndexOf(":") - 2));

                            }
                            Console.WriteLine(dane[0] + dane[1] + dane[2]);
                            var user5 = new Rozmowy { idR = (id + 1) };
                            try {
                                Console.WriteLine(dane[0]+dane[1]+dane[2]);
                                user5.idP = Convert.ToInt32(dane[0]);
                                user5.idPo = Convert.ToInt32(dane[1]);
                                user5.dataRozmowy = Convert.ToDateTime(dane[2]);
                                entity.Rozmowy.Add(user5);
                            }
                            catch (Exception)
                            {
                                this.Close();
                            }
                            break;
                        case "stan_dzial":
                            id = entity.stan_dzial.Max(u => u.idD);

                         
                            for (int i = 1; i < Stos.Children.Count; i += 2)
                            {
                                dane.Add(Stos.Children[i].ToString().Substring(Stos.Children[i].ToString().IndexOf(":") + 2, Stos.Children[i].ToString().Length - Stos.Children[i].ToString().IndexOf(":") - 2));

                            }
                            try { 
                            var user6 = new stan_dzial();
                            user6.idS = Convert.ToInt32(dane[0]);
                            user6.idD = Convert.ToInt32(dane[1]);
                            entity.stan_dzial.Add(user6);
                            }
                            catch (Exception)
                            {
                                this.Close();
                            }
                            

                            break;
                       
                        default:
                            try { 
                            id = entity.Pracownicy.Max(u => u.idP);
                    }
                            catch (Exception)
                    {
                        id = 0;
                    }

                    for (int i = 1; i < Stos.Children.Count; i += 2)
                            {
                                dane.Add(Stos.Children[i].ToString().Substring(Stos.Children[i].ToString().IndexOf(":") + 2, Stos.Children[i].ToString().Length - Stos.Children[i].ToString().IndexOf(":") - 2));

                            }
                           
                            var user7 = new Pracownicy { idP = (id + 1) };
                            try
                            {
                                
                                
                                user7.imieP = dane[0].ToString();
                                user7.nazwiskoP = dane[1].ToString();
                                user7.miastoP = dane[2].ToString();
                                user7.adresP = dane[3].ToString();
                                user7.nrTelP = dane[4];
                                user7.placaP = Convert.ToDouble(dane[5]);
                                entity.Pracownicy.Add(user7);
                                System.Console.WriteLine(dane[4]);
                            }
                            catch (Exception)
                            {
                                this.Close();
                            }
                            break;
                    }
                    try
                    {
                        entity.SaveChanges();
                    }
                    catch (EntitySqlException)
                    {
                        
                    }
                    this.Close();
                    
                }
            }
            else
            {
                MessageBox.Show("Wybierz tebele");
            }
           
        }

        private void Stos_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private int numberOfReps(String tekst,String znak)
        {
            int count=0;
            for(int i = 0; i < tekst.Length; i++)
            {
                if ((i + znak.Length) <= tekst.Length)
                {
                    if (tekst.Substring(i, znak.Length).Equals(znak))
                    {
                        count++;
                    }
                }
                else
                {
                    break;
                }
                
            }
            return count;
        }
        private List<String> getColTitels()
        {
            using (var entity = new kadryEntities2())
            {
                List<String> count = entity.Database.SqlQuery<String>("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + box.SelectedItem.ToString() + "' AND TABLE_SCHEMA = 'dbo' AND COLUMN_NAME != 'idR'").ToList(); ;
                return count;
            }
        }
    }
}
