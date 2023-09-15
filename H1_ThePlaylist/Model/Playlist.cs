using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_ThePlaylist.Model
{
    /// <summary>
    /// Class <see cref="Playlist"/> represents a playlist
    /// </summary>
    internal class Playlist
    {
        private string _name;
        private LinkedList<MusicTrack> _tracks = new LinkedList<MusicTrack>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Playlist"/> class, using multiple arugments
        /// </summary>
        /// <param name="name">name of playlist</param>
        /// <param name="tracks">tracks in playlist</param>
        public Playlist(string name, LinkedList<MusicTrack> tracks)
        {
            _name = name;
            _tracks = tracks;
        }

        public string Name
        {
            get { return _name; }
        }

        public LinkedList<MusicTrack> Tracks
        { 
            get { return _tracks; } 
        }
    }
}
