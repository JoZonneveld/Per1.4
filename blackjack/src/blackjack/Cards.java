package blackjack;

/**
 * Created by Joost on 30-4-2017.
 */
public class Cards
{
    public String kind;
    public String number;
    public int value;
    public boolean availeble;

    public Cards(String Kind, String Number, int Value)
    {
        this.kind = Kind;
        this.number = Number;
        this.value = Value;
        this.availeble = true;
    }

    public void draw()
    {
        this.availeble = false;
    } // cards is not availeble anymore

}
