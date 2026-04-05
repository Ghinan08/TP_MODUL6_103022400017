using TP_MODUL6_103022400017;

SayaMusicTrack track1 = new SayaMusicTrack("heavy rotation");

Console.WriteLine("Data awal");
track1.PrintTrackDetails();

Console.WriteLine("setelah ditambah play count");
track1.IncreasePlayCount(50000);
track1.PrintTrackDetails();