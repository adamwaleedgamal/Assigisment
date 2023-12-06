using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class Signup : Page
    {
        Login_Desktop_ApplicationEntities4 db = new Login_Desktop_ApplicationEntities4();
        Allatribite user = new Allatribite();
        public Signup()
        {
            InitializeComponent();
        }
        public void isvalid(string pass)
        {
            bool upper, lower, num, sumbols;
            upper = lower = num = sumbols = false;
            string spiecal = "!@#$%^&*().";
            foreach (char c in pass)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    upper = true;
                }
                else  if (c >= 'a' && c <= 'a')
                {
                    lower = true;
                }
                else if (c >= '0' && c <= '9')
                {
                    num = true;
                }
                else if (spiecal.Contains(c))
                {
                    sumbols = true;
                }
            }
            if (upper&&lower&&num&&sumbols)
            {
                user.user_Passwordd = Passwordup_txt.Text;
            }
            else
            {
                MessageBox.Show("invaild password");
            }
        }
        private void Sign_in_but_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.NavigationService.Navigate(login);
        }
        private void Sign_Up_but_Click(object sender, RoutedEventArgs e)
        {
            user.user_Username = usernameup_txt.Text;
            isvalid(Passwordup_txt.Text);
            var age = int.Parse(Ageup_txt.Text);
            if (age >= 18 && age <= 60)
            {
                user.user_Age = age;
            }
            else
            {
                MessageBox.Show("invalid AGE");
            }
            if (Phonenumup_txt.Text.Length ==11)
            {
                user.user_Phonenumber = Phonenumup_txt.Text;
            }
            if(combocityup.Text == "Egypt")
            {
                user.user_City = combocityup.Text;
            }
             else if (combocityup.Text == "Spain")
            {
                user.user_City = combocityup.Text;
            }
            else if (combocityup.Text == "France")
            {
                user.user_City = combocityup.Text;
            }
            else if (combocityup.Text == "Germany")
            {
                user.user_City = combocityup.Text;
            }
            else if (combocityup.Text == "Brazil")
            {
                user.user_City = combocityup.Text;
            }
            else
            {
                MessageBox.Show("Please choose city");
            }
            db.Allatribites.Add(user);
            db.SaveChanges();
            MessageBox.Show("Done");
            Login l = new Login();
            this.NavigationService.Navigate(l);
        }
    }
}