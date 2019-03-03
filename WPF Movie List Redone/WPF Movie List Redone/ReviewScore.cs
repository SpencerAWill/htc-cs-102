using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Movie_List_Redone
{
    class ReviewScore
    {
        private double _reviewScore;

        public ReviewScore(int score, int outOf)
        {
            _reviewScore = score / outOf;
        }
    }
}
