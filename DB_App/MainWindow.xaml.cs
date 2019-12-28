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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dodawanie_Prac a=new Dodawanie_Prac(login, haslo);
            a.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DodajPodanie a = new DodajPodanie(login,haslo);
            a.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Usun a = new Usun(login, haslo);
            a.Show();
        }

        public MainWindow(String uid,String password)
        {
            InitializeComponent();
            this.login = uid;
            this.haslo = password;
            Conector con = new Conector(login, haslo);

            myGrid.DataContext = con.Select("SELECT * FROM pracownicy;");
           // myGrid.DataContext = zasob1.DzialyDataTable.GetDataTableSchema();
        }
    }
}

