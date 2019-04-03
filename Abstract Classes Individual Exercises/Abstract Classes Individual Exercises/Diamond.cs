using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Ink;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Abstract_Classes_Individual_Exercises
{
    public class Diamond : Shape
    {
        private int _xPos { get; set; } = 100;
        private int _yPos { get; set; } = 100;
        private int _width { get; set; } = 100;
        private int _height { get; set; } = 100;

        public Diamond(SolidColorBrush fillColor, SolidColorBrush strokeColor, int width, int height)
        {
            Stroke = strokeColor;
            Fill = fillColor;
            _width = width;
            _height = height;
        }

        public Diamond(SolidColorBrush fillColor, SolidColorBrush strokeColor, int width, int height, int xPos, int yPos)
        {
            Stroke = strokeColor;
            Fill = fillColor;
            _width = width;
            _height = height;
            _xPos = xPos;
            _yPos = yPos;
        }


        protected override Geometry DefiningGeometry
        {
            get
            {
                PathFigure myPathFigure = new PathFigure();
                myPathFigure.StartPoint = new Point(_xPos + (_width/2), _yPos); //top middle

                LineSegment segment1 = new LineSegment();
                segment1.Point = new Point(_xPos + (_width), _yPos + (_height/2)); //middle right
                LineSegment segment2 = new LineSegment();
                segment2.Point = new Point(_xPos + (_width / 2), _yPos + _height);
                LineSegment segment3 = new LineSegment();
                segment3.Point = new Point(_xPos, _yPos + (_height/2));
                LineSegment segment4 = new LineSegment();
                segment4.Point = new Point(_xPos + (_width/2), _yPos);

                PathSegmentCollection myPathSegmentCollection = new PathSegmentCollection();
                myPathSegmentCollection.Add(segment1);
                myPathSegmentCollection.Add(segment2);
                myPathSegmentCollection.Add(segment3);
                myPathSegmentCollection.Add(segment4);

                myPathFigure.Segments = myPathSegmentCollection;

                PathFigureCollection myPathFigureCollection = new PathFigureCollection();
                myPathFigureCollection.Add(myPathFigure);

                PathGeometry myPathGeometry = new PathGeometry();
                myPathGeometry.Figures = myPathFigureCollection;

                return myPathGeometry;
            }
        }
    }
}
