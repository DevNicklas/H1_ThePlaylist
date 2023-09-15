using H1_ThePlaylist.Model;
using H1_ThePlaylist.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_ThePlaylist.Controller
{
    /// <summary>
    /// Class <see cref="MainController"/> controls the whole program
    /// </summary>
    internal class MainController
    {
        /// <summary>
        /// Starts the program
        /// </summary>
        public void Start()
        {
            Gui gui = new Gui();

            // Linked List of tracks
            LinkedList<MusicTrack> tracks = CreateTracks();

            // List of playlists
            List<Playlist> playlists = CreatePlaylists(tracks);

            gui.ShowAllTracks(tracks);

            gui.ShowPlaylists(playlists);
        }

        /// <summary>
        /// Creates a list of tracks
        /// </summary>
        /// <returns>A linked list of music tracks</returns>
        public LinkedList<MusicTrack> CreateTracks()
        {
            #region Tracks
            MusicTrack track1 = new MusicTrack("The Start", "Zach Diamond", 182);
            MusicTrack track2 = new MusicTrack("Gang Gang", "Mowgli", 130);
            MusicTrack track3 = new MusicTrack("Bayaka", "Berg", 420);
            MusicTrack track4 = new MusicTrack("Ørn", "Jimilian", 127);
            #endregion

            // Initializes a Linked list with tracks and adds 4 tracks to it
            LinkedList<MusicTrack> tracks = new LinkedList<MusicTrack>();
            tracks.AddLast(track1);
            tracks.AddLast(track2);
            tracks.AddLast(track3);
            tracks.AddLast(track4);

            return tracks;
        }

        /// <summary>
        /// Creates a playlist with a name, and tracks
        /// </summary>
        /// <param name="tracks">tracks to put in playlist</param>
        /// <returns></returns>
        public List<Playlist> CreatePlaylists(LinkedList<MusicTrack> tracks)
        {
            // Temporary list of tracks, so that the original track list isn't manipulated with
            LinkedList<MusicTrack> tempTracks = new LinkedList<MusicTrack>();
            foreach(MusicTrack track in tracks)
            {
                tempTracks.AddLast(track);
            }

            // Playlist1
            Playlist playlist1 = new Playlist("Homemade", tempTracks);

            // Playlist2
            tempTracks.RemoveLast();
            Playlist playlist2 = new Playlist("Rawr", tempTracks);

            // Initializes a list of playlists and adds the current playlists to the list
            List<Playlist> allPlayerlists = new List<Playlist>()
            {
                playlist1, playlist2
            };

            return allPlayerlists;
        }
    }
}
