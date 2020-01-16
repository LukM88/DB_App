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
            Dodaj a = new Dodaj(login,haslo);
            a.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Usun a = new Usun(login, haslo);
            a.Show();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        public MainWindow(String uid,String password)
        {
            InitializeComponent();
            this.login = uid;
            this.haslo = password;
            
            using (var entity = new kadryEntities())
            {
                var tab = entity.TABELE.ToArray();
                List<String> tabele=new List<string>();
                for(int i = 0; i < tab.Length; i++)
                {
                    tabele.Add(tab[i].TABLE_NAME.ToString());
                }
                box.ItemsSource = tabele;
                box.SelectedIndex = 0;
                System.Console.WriteLine();
                switch (box.Text)
                {
                    
                    default:
                        var tab2=entity.Pracownicy.ToArray();
                        myGrid.DataContext = tab2;
                        break;
                }
               
            }

            // myGrid.DataContext = zasob1.DzialyDataTable.GetDataTableSchema();
        }
    }
}

