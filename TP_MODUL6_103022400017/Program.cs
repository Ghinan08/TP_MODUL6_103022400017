using TP_MODUL6_103022400017;

SayaMusicTrack track1 = new SayaMusicTrack("aitakatta");
Console.WriteLine("kondisi awal");
track1.PrintTrackDetails();
Console.WriteLine("menguji exception overflow");
try
{
    for (int i = 0; i < 300; i++)
    {
      track1.IncreasePlayCount(10000000);
    }
}
catch (OverflowException ex)
{
    Console.WriteLine("terjadi error : batas maksimum integer terlampaui");
    Console.WriteLine("pesan sistem : "+ ex.Message);
}
Console.WriteLine("kondisi akhir setelah catch");
track1.PrintTrackDetails();