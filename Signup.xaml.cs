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
    /// <summary>
    /// Interaction logic for Signup.xaml
    /// </summary>
    public partial class Signup : Page
    {
        anaEntities db = new anaEntities();
        public Signup()
        {
            InitializeComponent();
        }

        private void Sign_in_but_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.NavigationService.Navigate(login);
        }

        private bool Isvalid(string pass)
        {
            bool lower, digit, specialchar;
            string set = "@#$%^&*()_+=}{/?><|";
            lower = digit = specialchar = false;


            foreach (char s in pass)
            {

                if (s >= 'a' && s <= 'z')
                {
                    lower = true;
                }
                else if (s >= '0' && s <= '9')
                {
                    digit = true;
                }
                else if (set.Contains(s))
                {
                    specialchar = true;
                }

            }

            return lower && digit && specialchar;
        }
        private void Sign_Up_but_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Allatribite tab = new Allatribite();
                tab.user_Username = usernameup_txt.Text;

                if (int.Parse(Ageup_txt.Text) >= 18 && int.Parse(Ageup_txt.Text) <= 60)
                {
                    tab.user_Age = int.Parse(Ageup_txt.Text);
                }
                else
                {
                    MessageBox.Show("Age must be between 18 and 60");
                }

                if (Isvalid(Passwordup_txt.Text))
                {
                    tab.user_Passwordd = Passwordup_txt.Text;
                }

                else
                {
                    MessageBox.Show("Pass must contain lower , upper , digits , Special chars");
                }
                tab.user_City = combocityup.Text;
                tab.user_Gender = Gendercombo.Text;
                db.Allatribites.Add(tab);
                db.SaveChanges();
                MessageBox.Show("Data  added successfully");
                Login login = new Login();
                this.NavigationService.Navigate(login);
            }
            catch
            {
                MessageBox.Show("wrong input");
            }
        }
    }
}
    