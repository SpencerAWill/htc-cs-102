﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class Dog : Animal
    {
        public string _breed;

        public void Bark()
        {
            MessageBox.Show("Bark");
        }
        

        public Dog() { }

        public Dog(string breed, int height, string name)
        {
            _breed = breed;
            _height = height;
            _name = name;
        }
    }
}