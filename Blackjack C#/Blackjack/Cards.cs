namespace Blackjack
{
    public class Cards
    {
        public string kind;
        public string number;
        public int value;

        public Cards(string Kind, string Number, int Value)
        {
            this.kind = Kind;
            this.number = Number;
            this.value = Value;
        }
    }
}