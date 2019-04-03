using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Abstract_Classes_Individual_Exercises
{
    public class AnySidedPolygon : Shape
    {
        private int _xPos { get; set; } = 100;
        private int _yPos { get; set; } = 100;

        private List<Point> allPoints = new List<Point>();

        public AnySidedPolygon(int sides, int radius,SolidColorBrush fillColor, SolidColorBrush StrokeColor)
        {
            double fullRotation = Math.PI * 2;
            for (int sidePoint = 1; sidePoint <= sides; sidePoint++)
            {
                
            }
        }

        protected override Geometry DefiningGeometry
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        
















    }
}
