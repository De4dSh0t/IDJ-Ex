namespace Ex_OnlineRadioDatabase_Inheritance
{
    public class InvalidSongLengthException : InvalidSongException
    {
        public InvalidSongLengthException() : base("Invalid song lenght.") {}
        
        public InvalidSongLengthException(string message) : base(message) {}
    }
}