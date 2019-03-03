using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Movie_List_Redone
{
    public static class MovieInstanceController
    {
        private static int _referenceIdCounter = 0;

        public static int getNewReferenceId()
        {
            _referenceIdCounter++;
            return _referenceIdCounter;
        }
    }
}
