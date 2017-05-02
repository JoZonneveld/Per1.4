package blackjack;

import java.util.List;

/**
 * Created by Joost on 30-4-2017.
 */
public class Player {
    public List<Cards> Hand;
    public String Name;

    public Player(String name)
    {
        this.Name = name;
    }

    public void CheckHand()
    {
        int output = 0;
        for(int i = 0; i < Hand.size(); i++){
            output += Hand.get(i).value;
        }
        System.out.println("Uw totaal is " + output);
    }
}
