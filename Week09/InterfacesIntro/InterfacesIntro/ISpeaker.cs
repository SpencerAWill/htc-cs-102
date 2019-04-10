using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceIntro
{
    public interface ISpeaker
    {
        string Name { get; }
        int Height { get; }
        void Speak();
    }
}
