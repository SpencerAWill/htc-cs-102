using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    public class Genre : Tag
    {
        public string _genreName;

        public Genre(string genreName)
        {
            _genreName = genreName;
        }
    }
}
