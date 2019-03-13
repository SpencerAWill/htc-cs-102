using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PolymorphismIntro
{
    public class Animal
    {
        public int Height;
        public string Name;

        public void SayName()
        {
            MessageBox.Show("My name is " + Name);
        }
    }
}
