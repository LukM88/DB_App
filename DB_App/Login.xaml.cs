using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window 
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

               using (var entity = new kadryEntities())
               {

                  // var user = entity.AspNetUsers.Where(x=>x.UserName==login.Text && Convert.FromBase64String(x.PasswordHash)== haslo.Password  ).FirstOrDefault();
                   //if (user!=null)
                  // {
                MainWindow app = new MainWindow(login.Text, haslo.Password);
          
                app.Show();

                this.Close(); 
               

    
            }
              
        }
    }
}
