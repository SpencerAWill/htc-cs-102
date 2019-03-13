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

namespace PolymorphismIntro
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
            Frog frog = new Frog(4, "Kermit", false, 5);
            Dog dog = new Dog("Muppet", 20, "Snoop", 15);
            Duck duck = new Duck(9, "Donald", 10);

            Dog dog1 = new Dog("none", 200, "Clifford", 1000);
            Duck duck1 = new Duck(5, "Daffy", 60);
            Frog frog1 = new Frog(3, "Jeremiah", false, 15);

            Animals.Add(frog);
            Animals.Add(duck);
            Animals.Add(dog);
            Animals.Add(dog1);
            Animals.Add(duck1);
            Animals.Add(frog1);

            lvAnimals.ItemsSource = Animals;
        }

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog dog = new Dog();
            dog.Bark();
        }

        private void Quack_Button_Click(object sender, RoutedEventArgs e)
        {
            Duck duck = new Duck();
            duck.Quack();
        }

        private void Ribbit_Button_Click(object sender, RoutedEventArgs e)
        {
            Frog frog = new Frog();
            frog.Ribbit();
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var animal in Animals)
            {
                animal.SayName();
                
            }
        }

        private void lvAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (object selectedItem in lvAnimals.SelectedItems)
            {
                Animal selectedAnimal = selectedItem as Animal;
                if (selectedAnimal != null)
                {
                    selectedAnimal.Speak();
                    
                }
            }
        }
    }
}
