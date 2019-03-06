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

namespace InheritanceIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog dog = new Dog();
            dog.Bark();
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            // Define a new List of dogs
            List<Dog> dogs = new List<Dog>();
            
            // Instantiate some dog objects
            Dog dog1 = new Dog("Muppet", 20, "Rolf");
            Dog dog2 = new Dog("Golden Retriever", 30, "Air Bud");

            // Add the dogs to the list
            dogs.Add(dog1);
            dogs.Add(dog2);

            // Loop through the list and call a method on the objects
            foreach (Dog d in dogs)
            {
                d.SayName();
            }
        }
    }
}
