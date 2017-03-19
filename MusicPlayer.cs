using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicPlayer
{
    class MusicPlayer
    {
        private List<Artist> artists;
        private List<Song> songs;
        private List<Playlist> playlists;

        public MusicPlayer()
        {
            this.artists = new List<Artist>();
            this.songs = new List<Song>();
            this.playlists = new List<Playlist>();
        }

        public void Add(Artist artist)
        {
            artists.Add(artist);
        }

        public void Add(Song song)
        {
            songs.Add(song);
        }

        public void Add(Playlist playlist)
        {
            playlists.Add(playlist);
        }

        public void Remove(Playlist playlist)
        {
            playlists.Remove(playlist);
        }

        public void Play(Song song)
        {
            // later in te vullen
        }

        public void Play(Playlist playlist)
        {
            // later in te vullen
        }

        public Song Playing()
        {
            // later in te vullen
            return null;
        }

        public void StopPlaying()
        {
            // later in te vullen
        }
    }
}
