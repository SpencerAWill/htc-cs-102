using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PolymorphismIntro
{
    public class Duck : Animal
    {
        public void Quack()
        {
            MessageBox.Show("Quack");
        }

        public Duck() { }

        public Duck(int height, string name)
        {
            this.Height = height;
            this.Name = name;
        }
    }
}