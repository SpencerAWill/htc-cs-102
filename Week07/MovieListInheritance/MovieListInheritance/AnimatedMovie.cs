using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieListInheritance
{
    public class AnimatedMovie : Movie
    {
        public string _animationStudio { get; set; }
        public string _animationType { get; set; }
        private string _title;
        private DateTime _releaseYear;

        public AnimatedMovie(string title, DateTime releaseYear, string animationStudio, string animationType)
        {
            _title = title;
            _releaseYear = releaseYear;
            _animationStudio = animationStudio;
            _animationType = animationType;
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Studio: " + _animationStudio);
            Console.WriteLine("Type: " + _animationType);
            Console.WriteLine("Title: " + _title);
            Console.WriteLine("Release Year: " + _releaseYear.Year);
        }
    }
}
