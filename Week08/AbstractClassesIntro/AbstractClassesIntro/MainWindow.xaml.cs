using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace AbstractClassesIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Animal> Animals;

        public MainWindow()
        {
            InitializeComponent();
            Animals = new ObservableCollection<Animal>();
            
            // Define some animals
            Frog frog = new Frog(4, "Kermit", false);
            Dog dog = new Dog("Muppet", 20, "Rolf");
            Duck duck = new Duck(9, "Donald");

            // Add the animals to the list
            Animals.Add(frog);
            Animals.Add(dog);
            Animals.Add(duck);
            
            lvAnimals.ItemsSource = Animals;
        }

        private void lvAnimals_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Animal selectedAnimal = lvAnimals.SelectedItem as Animal;
            if (selectedAnimal != null)
            {
                selectedAnimal.Speak();
            }
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            // Loop through the list and call a method on the objects
            foreach (Animal a in Animals)
            {
                a.SayName();
            }
        }
    }
}
