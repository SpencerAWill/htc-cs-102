using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;


namespace Abstract_Classes_Individual_Exercises
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Diamond myDiamond = new Diamond(Brushes.Pink, Brushes.Red, 100, 20, 400, 300);


            Canvas.SetLeft(myDiamond, 100);
            Canvas.SetTop(myDiamond, 100);

            myCanvas.Children.Add(myDiamond);
        }
    }
}
