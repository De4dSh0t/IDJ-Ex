namespace Ex_OnlineRadioDatabase_Inheritance
{
    public class InvalidArtistNameEception : InvalidSongException
    {
        public InvalidArtistNameEception() : base("Artist name should be between 3 and 20 symbols.") {}
        
        public InvalidArtistNameEception(string message) : base(message) {}
    }
}