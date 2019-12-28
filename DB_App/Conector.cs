using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace DB_App
{
    class Conector
    {
        static private bool flaga=true;
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Conector(String nazwa, String haslo)
        {
            Initialize(nazwa, haslo);
        }
        private void Initialize(String nazwa, String haslo)
        {
            server = "localhost";
            database = "kadry";
            uid = nazwa;
            password = haslo;
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            if (OpenConnection() && flaga==true)
            {
                flaga = false;
                MainWindow a=new MainWindow(uid,password);
                a.Show();
                CloseConnection();
            }

        }

        

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert()
        {

        }
        public void InsertPrac(string text1, string text2, string text3, string text4, string text5, string text6)
        {
            if (text6.Length == 9)
            {
                try
                {
                    String query = "INSERT INTO `kadry`.`pracownicy` (`imie`, `nazwisko`, `miasto`, `adres`, `placa`, `nr_tel`) VALUES (" + text1 + "," + text2 + "," + text3 + " ," + text4 + "," + Convert.ToDouble(text5) + "," + text6 + ");";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteReader();

                }
                catch (Exception e)
                {
                    MessageBox.Show("Błąd kwerędy");
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Numer nieprawidłowy!");
            }
           
            
        }
        public void InsertKan(string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9, string text10)
        {
            if (text8.Length == 9)
            {
                try
                {
                    String query = " INSERT INTO `kadry`.`podania` (`imie`, `nazwisko`, `data_uro`, `data_zglosz`, `wyksztalcenie`, `miasto`, `adres`, `nr_tel`, `Oferty_idOferty`, `Oferty_Stanowiska_idStanowiska`) VALUES (" + text1 + "," + text2 + ",'" + text3 + "' ,'" + text4 + "'," +text5+ "," + text6 + "," + text7 + " ," + text8 + "," + Convert.ToInt32(text9) + "," + Convert.ToInt32(text10) + ");";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteReader();

                }
                catch (Exception e)
                {
                    MessageBox.Show("Błąd kwerędy");
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Numer nieprawidłowy!");
            }


        }

        //Update statement
        public void Update(String query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            DataTable dt = new DataTable();
            try
            {
                dt.Load(cmd.ExecuteReader());

            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd kwerędy");
            }
            finally
            {
                connection.Close();
            }
        }

        //Delete statement
        public void Delete(String query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd kwerędy");
            }
            finally
            {
                connection.Close();
            }
        }

        //Select statement
        public DataTable Select(String quer)
        {
            MySqlCommand cmd = new MySqlCommand(quer, connection);

            DataTable dt = new DataTable();
            try
            {
                dt.Load(cmd.ExecuteReader());

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
            return dt;

        }

        //Count statement
        public int Count()
        {
            return 1;
        }

        //Backup
        public void Backup()
        {

        }

        //Restore
        public void Restore()
        {

        }
    }
}
