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

namespace InheritanceIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ISpeaker> Speakers;

        public MainWindow()
        {
            InitializeComponent();
            Speakers = new ObservableCollection<ISpeaker>();

            // Define some animals
            Frog frog = new Frog(4, "Kermit", false);
            Dog dog = new Dog("Muppet", 20, "Rolf");
            Duck duck = new Duck(9, "Donald");

            // Add the animals to the list
            Speakers.Add(frog);
            Speakers.Add(dog);
            Speakers.Add(duck);

            // Add robots too!
            Robot robot = new Robot("R.O.B.", 2555);
            Speakers.Add(robot);

            lvAnimals.ItemsSource = Speakers;
        }

        private void lvAnimals_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ISpeaker selectedSpeaker = lvAnimals.SelectedItem as ISpeaker;
            if (selectedSpeaker != null)
            {
                selectedSpeaker.Speak();
            }
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            // Loop through the list and call a method on the objects
            foreach (ISpeaker s in Speakers)
            {
                // cannot call the SayName method here
                //a.SayName();
            }
        }
    }
}
