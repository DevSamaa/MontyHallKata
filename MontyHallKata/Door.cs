namespace MontyHallKata
{
    public class Door
    {
        public bool Winner { get; set; }
        public bool Open { get; set; }
        public bool Chosen { get; set; }
        public int Number { get; set; }

        public Door(int incomingNumber)
        {
            // Winner = false;
            // Open = false;
            // Chosen = false;
            Number = incomingNumber;
        }
        
    }
}