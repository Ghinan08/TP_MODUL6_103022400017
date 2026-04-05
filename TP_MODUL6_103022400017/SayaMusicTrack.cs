using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace TP_MODUL6_103022400017
{
    internal class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;
        public SayaMusicTrack(string title)
        {
            this.title = title;
            Random random = new Random();
            this.id = random.Next(10000, 100000);

            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("Track ID   : " + this.id);
            Console.WriteLine("Title      : " + this.title);
            Console.WriteLine("Play Count : " +this.playCount);
            Console.WriteLine("---------------------------------");
        }
    }
}
