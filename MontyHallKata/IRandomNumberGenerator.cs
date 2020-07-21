namespace MontyHallKata
{
    public interface IRandomNumberGenerator
    {
        public int Generate();
        public int Generate(int minValue, int maxValue);
    }
}