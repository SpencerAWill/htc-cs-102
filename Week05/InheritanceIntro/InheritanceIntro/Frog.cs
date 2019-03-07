using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class Frog : Animal
    {
        public int _jumpHeight;
        public bool _isPoisonous;

        public void ribbit()
        {
            MessageBox.Show("Ribbit!");
        }
    }
}
