package blackjack;

import java.util.ArrayList;
import java.util.List;

public class Bot implements IPlayer
{
    public List<Cards> Hand;
    public String Name;
    public int Count;

    public Bot()
    {
        this.Name = "Bot Harold";
        //this.Hand = CreateHand();
    }

    public void CountPlus()
    {
        this.Count++;
    }

    public void CountMin()
    {
        this.Count--;
    }

    public int CheckHand()
    {
        int output = 0;
        for(int i = 0; i < Hand.size(); i++){
            output += Hand.get(i).value;
        }

        if(output > 21)
        {
            for(int i = 0; i < Hand.size(); i++)
            {
                if(Hand.get(i).number == "Ace")
                {
                    Hand.get(i).value = 1;
                }
            }
        }

        return output;
    }

    public List<Cards> CreateHand()
    {
        List<Cards> hand = new ArrayList<Cards>(); //card deck

        return hand;
    }
}
