namespace GangOfFourDesignPatterns.Creational
{
    public class Address
    {
        public Address(string line1, string line2)
        {
            Line1 = line1;
            Line2 = line2;
        }

        public string Line1 { get; private set; }

        public string Line2 { get; private set; }
    }
}