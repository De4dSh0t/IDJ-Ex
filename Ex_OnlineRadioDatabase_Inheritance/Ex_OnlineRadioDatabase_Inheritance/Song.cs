using System;

namespace Ex_OnlineRadioDatabase_Inheritance
{
    public class Song
    {
        private string artistName;
        private string songName;
        private TimeSpan time;

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

        public TimeSpan Time
        {
            get => time;
            set
            {
                if (value == TimeSpan.Zero) //Se o tempo for igual a zero
                {
                    throw new InvalidSongLengthException();
                }

                if (value == TimeSpan.FromMinutes(0) || value == TimeSpan.FromMinutes(15)) //Se o tempo não estiver entre 0 e 15 minutos
                {
                    throw new InvalidSongMinutesException();
                }
                
                if (value == TimeSpan.FromSeconds(0) || value == TimeSpan.FromSeconds(60)) //Se o tempo não estiver entre 0 e 60 segundos
                {
                    throw new InvalidSongSecondsException();
                }

                time = value;
            }
        }
    }
}