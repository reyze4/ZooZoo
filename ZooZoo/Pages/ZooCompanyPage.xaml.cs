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

namespace ZooZoo.Pages
{
    /// <summary>
    /// Логика взаимодействия для ZooCompanyPage.xaml
    /// </summary>
    public partial class ZooCompanyPage : Page
    {
        public ZooCompanyPage()
        {
            InitializeComponent();
            DGZooCompany.ItemsSource = App.DB.ZooCompany.ToList();
        }

        private void BDelete_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
