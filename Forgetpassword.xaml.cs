using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

namespace Registeration___Login_Desktop_Application
{
    /// <summary>
    /// Interaction logic for Forgetpassword.xaml
    /// </summary>
    public partial class Forgetpassword : Page
    {
        Login_Desktop_ApplicationEntities4 db = new Login_Desktop_ApplicationEntities4();
        public Forgetpassword()
        {
            InitializeComponent();
        }

        private void Update_Password_but_Click(object sender, RoutedEventArgs e)
        {
            Allatribite l = new Allatribite();

            l = db.Allatribites.FirstOrDefault(x => x.user_Phonenumber == Phoneforget_txt.Text);
            if (l != null)
            {
          if (newpasswordforget_txt.Text == Conformpassforget_txt.Text)
                {
                    l.user_Passwordd = newpasswordforget_txt.Text;
                }
                db.Allatribites.AddOrUpdate(l);
                db.SaveChanges();
                MessageBox.Show("Updated");
                Login login = new Login();
                this.NavigationService.Navigate(login);
            }
            else
            {
                MessageBox.Show("Error Happens");
            }
        }
    }
}
