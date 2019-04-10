using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class Duck : Animal
    {
        public override void Speak()
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