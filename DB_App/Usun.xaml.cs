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
using System.Windows.Shapes;

namespace DB_App
{
    /// <summary>
    /// Interaction logic for Usun.xaml
    /// </summary>
    public partial class Usun : Window
    {
        String a, b,tab;
        DataTable x = new DataTable();
        public Usun(String log,String pwd)
        {
            InitializeComponent();
            this.a = log;
            this.b = pwd;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Conector con = new Conector(a, b);
            switch (tabela.SelectedIndex)
            {
                case 2:
                    
                    x=con.Select("SELECT idPracownicy,imie,nazwisko FROM rozmowy WHERE nazwisko LIKE '%"+nazwisko.Text+"%';");
                    grid.DataContext = x;
                    break;
                case 5:
                    x = con.Select("SELECT idPracownicy FROM pracownicy WHERE nazwisko LIKE '%" + nazwisko.Text + "%';");
                    grid.DataContext = x; break;
                case 6:
                    x = con.Select("SELECT idPracownicy FROM pracownicy WHERE nazwisko LIKE '%" + nazwisko.Text + "%';");
                    grid.DataContext = x; break;
                case 7:
                    x = con.Select("SELECT idPracownicy FROM pracownicy WHERE nazwisko LIKE '%" + nazwisko.Text + "%';");
                    grid.DataContext = x;
                    break;
                case 1:
                    x = con.Select("SELECT idPracownicy,imie,nazwisko FROM pracownicy WHERE nazwisko LIKE '%" + nazwisko.Text + "%';");
                    grid.DataContext = x;
                    break;
                case 3:
                    x = con.Select("SELECT idPracownicy FROM pracownicy WHERE nazwisko LIKE '%" + nazwisko.Text + "%';");
                    grid.DataContext = x;
                    break;
                case 4:
                    x = con.Select("SELECT idPracownicy FROM pracownicy WHERE nazwisko LIKE '%" + nazwisko.Text + "%';");
                    grid.DataContext = x;
                    break;
                    



            }
            
            grid.UpdateLayout();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Conector con = new Conector(a, b);
            switch (tabela.SelectedIndex)
            {
                case 2:
                    con.Delete("DELETE FROM `kadry`.`pracownicy` WHERE (`idPracownicy` = '" +Convert.ToInt32(id2.Text)+ "');");
                    break;
                case 5:
                    con.Delete("DELETE FROM `kadry`.`dzial` WHERE (`idDzial` = '" + Convert.ToInt32(id2.Text) + "');");
                    break;
                case 6:
                    con.Delete("DELETE FROM `kadry`.`pracownicy` WHERE (`idPracownicy` = '"+Convert.ToInt32(id2.Text) + "');");
                    break;
                case 7:
                    con.Delete("DELETE FROM `kadry`.`oferty` WHERE (`idOferty` = '" + id.Text + "') and (`Stanowiska_idStanowiska` = '" + Convert.ToInt32(id2.Text) + "');");

                    break;
                case 1:
                    con.Delete("DELETE FROM `kadry`.`pracownicy` WHERE (`idPracownicy` = '" + Convert.ToInt32(id2.Text) + "');");
                    break;
                case 3:
                    con.Delete("DELETE FROM `kadry`.`pracownicy` WHERE (`idPracownicy` = '" + Convert.ToInt32(id2.Text) + "');");
                    break;
                case 4:
                    con.Delete("DELETE FROM `kadry`.`pracownicy` WHERE (`idPracownicy` = '" + Convert.ToInt32(id2.Text) + "');");
                    break;


                

            }
           
            this.Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tab =  tabela.SelectedItem.ToString();
            tab = tab.Substring(tab.IndexOf(":") + 1);
            
            if (tabela.SelectedIndex==6 && id2.Visibility== Visibility.Collapsed && id2txt.Visibility== Visibility.Collapsed)
            {
                id2txt.Visibility = Visibility.Visible;
                id2.Visibility = Visibility.Visible;

            }
            else
            {

                id2txt.Visibility = Visibility.Collapsed;
                id2.Visibility = Visibility.Collapsed;
            }
            id2.UpdateLayout();
            
        }
    }
}
