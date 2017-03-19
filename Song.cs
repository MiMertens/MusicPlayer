using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicPlayer
{
    class Song
    {
        //fields
        private string name;
        private int year;
        private Artist musisian;

        //constructor
        public Song(string name, int year, Artist artist)
        {
            this.name = name;
            this.year = year;
            musisian = artist;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", name, musisian, year);
        }
    }
}
