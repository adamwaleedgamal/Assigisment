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
    public partial class Delete : Page
    {
        Login_Desktop_ApplicationEntities4 db = new Login_Desktop_ApplicationEntities4();
        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_but_Click(object sender, RoutedEventArgs e)
        {

            Allatribite l = new Allatribite();

            l = db.Allatribites.Remove(db.Allatribites.First(x => x.user_Phonenumber == Ph_txt.Text ));
            if (l != null)
            {
                db.SaveChanges();
                MessageBox.Show("The Task is done");
             
            }

            else
            {
                MessageBox.Show("Error Happens");
            }
        }
    }
}