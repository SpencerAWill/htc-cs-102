using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassesIntro
{
    public class Dog
    {
        public string Breed;
        public int Height;
        public string Name;

        public Dog(string name, string breed, int height)
        {
            this.Breed = breed;
            this.Height = height;
            this.Name = name;
        }


        public void Bark()
        {
            MessageBox.Show("Woof Woof");
        }

        public void sayName()
        {
            MessageBox.Show("My name is " + Name + ".");
        }
    }
}