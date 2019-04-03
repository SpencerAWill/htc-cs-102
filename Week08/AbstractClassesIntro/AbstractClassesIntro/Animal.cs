using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AbstractClassesIntro
{
    public class Animal
    {
        public int Height
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public void SayName()
        {
            MessageBox.Show("My name is " + Name);
        }

        public virtual void Speak()
        {

        }
    }
}
