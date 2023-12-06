using System;
using System.Collections.Generic;
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
    public partial class logoutusername : Page
    {
        public logoutusername( Allatribite a )
        {
            InitializeComponent();
            adam.Content = "welcome" + a.user_Username;
            UserName_.Content = "Name :" + a.user_Username;
            Password_.Content = "Password :" + a.user_Passwordd;
            Age_.Content = "Age :" + a.user_Age;
            Gender_.Content = "Gender :" + a.user_Gender;
            Phone_Number_.Content = "Phone Number :" + a.user_Phonenumber;
            City_.Content = "City :" + a.user_City;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login l = new Login();
            this.NavigationService.Navigate(l);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.NavigationService.Navigate(login);
        }
    }
}
