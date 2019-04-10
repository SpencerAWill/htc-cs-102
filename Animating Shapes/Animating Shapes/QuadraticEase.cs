using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace Animating_Shapes
{
    public class QuadraticEase : IEasingFunction
    {
        //quadratic function


        public double Ease(double normalizedTime)
        {
            return normalizedTime * normalizedTime;
        }
    }
}
