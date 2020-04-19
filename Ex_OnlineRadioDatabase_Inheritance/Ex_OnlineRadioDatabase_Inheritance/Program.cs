using System;

namespace Ex_OnlineRadioDatabase_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Song s = new Song();
            string numberSongs = Console.ReadLine();
            int nS = Int32.Parse(numberSongs);

            for (int i = 0; i < nS; i++)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] iWords = input.Split(";"); //Realiza o split entre ";"

                    s.ArtistName = iWords[0];
                    s.SongName = iWords[1];
                    s.Time += TimeSpan.Parse(iWords[2]); //Corresponde ao tempo da musica inserido
                    
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
            Console.WriteLine($"Playlist lenght: {s.Time}");
        }
    }
}