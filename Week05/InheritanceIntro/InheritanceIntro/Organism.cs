using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceIntro
{
    public class Organism
    {
        public string _dnaProfile;

        public Organism(string dnaProfile = "aaaaaaaaaaaaaa")
        {
            _dnaProfile = dnaProfile;
        }
    }
}
