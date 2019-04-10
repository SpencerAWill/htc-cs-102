using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class Robot : ISpeaker
    {
        public int Height
        {
            get
            {
                return 5;
            }
        }

        public string Name
        {
            get; set;
        }

        public int SerialNumber
        {
            get; set;
        }

        public void Speak()
        {
            MessageBox.Show("Hello, I am a robot. My name is " + Name + " and my serial number is " + SerialNumber);
        }

        public Robot(string name, int serialNumber)
        {
            Name = name;
            SerialNumber = serialNumber;
        }
    }
}
