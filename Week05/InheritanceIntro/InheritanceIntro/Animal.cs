using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class Animal : Organism
    {
        public string _name;
        public int _height;

        public void sayName()
        {
            MessageBox.Show("My name is: " + _name);
        }

        public override string ToString()
        {
            return base.ToString() + ": " + _name;
        }
    }
}
