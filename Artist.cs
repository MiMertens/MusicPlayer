using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicPlayer
{
    class Artist
    {
        //fields
        private string name;
        private List<Song> songs;

        //constructor
        public Artist(string name)
        {
            this.name = name;
            songs = new List<Song>();
        }
        // metohd for adding a song 
        public void Add(Song song)
        {
            songs.Add(song);
        }

        public override string ToString()
        {
            return name;
        }
    }
}
