namespace Ex_Telephony
{
    public interface IModel
    {
        public string Number { get; set; }
        public string URL { get; set; }

        public string Call();
        public string Browse();
    }
}