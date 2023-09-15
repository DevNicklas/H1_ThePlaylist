using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_ThePlaylist.Model
{
    /// <summary>
    /// Class <see cref="MusicTrack"/> represents a music by using multiple attributes
    /// </summary>
    internal class MusicTrack
    {
        private string _title;
        private string _artist;
        private ushort _length;

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicTrack"/> class, using multiple arugments
        /// </summary>
        /// <param name="title">title of music track</param>
        /// <param name="artist">artist of music track</param>
        /// <param name="length">length in seconds of music track</param>
        public MusicTrack(string title, string artist, ushort length)
        {
            _title = title;
            _artist = artist;
            _length = length;
        }

        public string Title
        {
            get { return _title; }
        }

        public string Artist
        {
            get { return _artist; }
        }

        public ushort Length
        {
            get { return _length; }
        }
    }
}
