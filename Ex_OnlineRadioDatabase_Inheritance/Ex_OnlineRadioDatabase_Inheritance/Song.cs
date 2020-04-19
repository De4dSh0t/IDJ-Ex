using System;

namespace Ex_OnlineRadioDatabase_Inheritance
{
    public class Song
    {
        TimeSpan time = new TimeSpan();
        
        private string artistName;
        private string songName;
        private int timeMinutes;
        private int timeSeconds;

        public string ArtistName
        {
            get => artistName;
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameEception();
                }

                artistName = value;
            }
        }

        public string SongName
        {
            get => songName;
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException();
                }

                songName = value;
            }
        }

        public int TimeMinutes
        {
            get => timeMinutes;
            set
            {
                if (value < 0 || value > 14) //Se não estiver entre 0 e 14 minutos
                {
                    throw new InvalidSongMinutesException();
                }

                timeMinutes = value;
            }
        }

        public int TimeSeconds
        {
            get => timeSeconds;
            set
            {
                if (value < 0 || value > 59) //Se não estiver entre 0 e 50 segundos
                {
                    throw new InvalidSongSecondsException();
                }

                timeSeconds = value;
            }
        }

        public TimeSpan PlayListLength()
        {
            time.Add(TimeSpan.FromMinutes(timeMinutes));
            time.Add(TimeSpan.FromSeconds(timeSeconds));

            return time;
        }
    }
}