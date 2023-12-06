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
    public partial class Login : Page
    {
        anaEntities db = new anaEntities();
        public Login()
        {
            InitializeComponent();
        }
        private void Login_but_Click(object sender, RoutedEventArgs e)
        {
            Allatribite l = new Allatribite();

            l = db.Allatribites.FirstOrDefault(x => x.user_Username == usernamelogin_txt.Text && x.user_Passwordd == PasswordLogin_txt.Text);
            if (l != null)
            {
  
                MessageBox.Show("Login Succefly");
                logoutusername aa = new logoutusername(l);
                this.NavigationService.Navigate(aa);
            }

            else
            {
                MessageBox.Show("Error Happens");
            }
        }
        private void Sign_Up_but_Click(object sender, RoutedEventArgs e)
        {
            Signup signup = new Signup();
            this.NavigationService.Navigate(signup);
        }
        private void Forget_Password_but_Click(object sender, RoutedEventArgs e)
        {
            Forgetpassword forgetpassword = new Forgetpassword();
            this.NavigationService.Navigate(forgetpassword);
        }
    }
}