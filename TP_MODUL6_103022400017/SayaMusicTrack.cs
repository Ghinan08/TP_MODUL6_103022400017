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
            Debug.Assert(title != null, "error: judul track tidak boleh null");
            Debug.Assert(title.Length <= 100, "error: judul track maksimal 100 karakter");
            this.title = title;
            Random random = new Random();
            this.id = random.Next(10000, 100000);

            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "error: input penambahan play count maksimal 10.000.000 per pemanggilan");

            checked
            {
                this.playCount += count;
            }
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("Track ID   : " + this.id);
            Console.WriteLine("Title      : " + this.title);
            Console.WriteLine("Play Count : " +this.playCount);
            Console.WriteLine("------------------------------");
        }
    }
}
