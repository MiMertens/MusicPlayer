using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicPlayer
{
    class Playlist
    {
        private string name;
        private List<Song> songs;

        public Playlist(string name)
        {
            this.name = name;
            songs = new List<Song>();
        }

        public void Add(Song song)
        {
            songs.Add(song);
        }

        public void Add(List<Song> songs)
        {
            foreach (Song song in songs)
            {
                Add(song);
            }
        }

        public void Remove(Song song)
        {
            songs.Remove(song);
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} Songs", name, songs.Count);
        }
    }
}
