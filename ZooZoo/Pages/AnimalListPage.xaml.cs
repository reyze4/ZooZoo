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
using ZooZoo.Components.Model;
using ZooZoo.Pages;

namespace ZooZoo.Pages
{
    /// <summary>
    /// Логика взаимодействия для AnimalListPage.xaml
    /// </summary>
    public partial class AnimalListPage : Page
    {
        public AnimalListPage()
        {
            InitializeComponent();
            LVAnimal.ItemsSource = App.DB.Animal.ToList();
        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            var selectedAnimal = LVAnimal.SelectedItem as Animal;
            if (selectedAnimal == null)
            {
                MessageBox.Show("Выберите записть");
                return;
            }
            NavigationService.Navigate(new AnimalListEditPage(selectedAnimal));
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
