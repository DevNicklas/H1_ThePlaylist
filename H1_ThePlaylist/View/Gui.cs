using H1_ThePlaylist.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_ThePlaylist.View
{
    /// <summary>
    /// Class <see cref="Gui"/> represents all graphical to the user
    /// </summary>
    internal class Gui
    {
        /// <summary>
        /// Prints all tracks in the program
        /// </summary>
        /// <param name="tracks">A list of tracks. Needs to contain at least one track</param>
        public void ShowAllTracks(LinkedList<MusicTrack> tracks)
        {
            Console.WriteLine("Alle sange i programmet:");

            // Writes all tracks by their titles
            for(int i = 0; i < tracks.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write($" {i+1}. ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(tracks.ToArray()[i].Title);
            }

            Console.ResetColor();
            Console.WriteLine();
        }

        /// <summary>
        /// Prints all playlists in the program
        /// </summary>
        /// <param name="playlists">A list of playlists. Needs to contain at least one playlist</param>
        public void ShowPlaylists(List<Playlist> playlists)
        {
            Console.WriteLine("Alle playlister i programmet:");

            for(int i = 0; i < playlists.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($" {i + 1}. ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(playlists[i].Name);
            }

            Console.ResetColor();
        }
    }
}
