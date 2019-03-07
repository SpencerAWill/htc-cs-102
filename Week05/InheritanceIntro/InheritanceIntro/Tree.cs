using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceIntro
{
    public class Tree : Organism
    {
        public int _height;
        public bool _isGrowing;
        public int _ageInYears;

        public Tree() { }

        public Tree(int height = 10, bool isGrowing = true, int ageInYears = 1)
        {
            _height = height;
            _isGrowing = isGrowing;
            _ageInYears = ageInYears;
        }
    }
}
