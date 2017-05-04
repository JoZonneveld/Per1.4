package blackjack;

import java.util.ArrayList;
import java.util.List;


public interface IPlayer
{
    List<Cards> Hand = new ArrayList<Cards>();
    String Name = null;

    int CheckHand();
    List<Cards> CreateHand();
}
