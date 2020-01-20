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
        private  connection;
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
        public void Insert(String query)
        {
            try
            {
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
