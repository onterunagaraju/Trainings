using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewStart
{
    internal class Movie
    {
        public string name;
        public string director;
        private int rating;

        public Movie(string name, string director, int rating)
        {
            this.name = name;
            this.director = director;
            this.Rating = rating;
        }

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
    }
}
