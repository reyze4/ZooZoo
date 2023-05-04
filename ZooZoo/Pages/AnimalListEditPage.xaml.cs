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
    /// Логика взаимодействия для AnimalListEditPage.xaml
    /// </summary>
    public partial class AnimalListEditPage : Page
    {
        Animal contextAnimal;
        public AnimalListEditPage(Animal animal)
        {
            InitializeComponent();
            contextAnimal = animal;
            DataContext = contextAnimal;
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            string error = "";

            if (contextAnimal.ID == 0)
                App.DB.Animal.Add(contextAnimal);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
