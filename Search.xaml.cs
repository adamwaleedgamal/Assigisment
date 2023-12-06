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
    public partial class Search : Page
    {
        Login_Desktop_ApplicationEntities4 db = new Login_Desktop_ApplicationEntities4();
        public Search()
        {
            InitializeComponent();
        }

        private void Serach_but_Click(object sender, RoutedEventArgs e)
        {
            gg.ItemsSource = db.Allatribites.Where(x => x.user_City.Contains(Citysearch_txt.Text)).ToList();
        }
    }
}
