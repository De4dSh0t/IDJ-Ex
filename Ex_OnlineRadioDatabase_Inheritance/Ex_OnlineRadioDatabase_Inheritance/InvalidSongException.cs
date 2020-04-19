using System;

namespace Ex_OnlineRadioDatabase_Inheritance
{
    public class InvalidSongException : Exception
    {
        public InvalidSongException() : base("Invalid song.") {}
        
        public InvalidSongException(string message) : base(message) {}
    }
}