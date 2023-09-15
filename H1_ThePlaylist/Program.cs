using H1_ThePlaylist.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_ThePlaylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainController mainCtrl = new MainController();
            mainCtrl.Start();
            Console.ReadLine();
        }
    }
}
