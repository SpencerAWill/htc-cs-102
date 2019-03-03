using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Movie_List_Redone
{
    class UIElement
    {
        private object _referenceObject;

        public UIElement(object referenceObject)
        {
            _referenceObject = referenceObject;
        }

        public object getReferenceObject()
        {
            return _referenceObject;
        }
    }
}
