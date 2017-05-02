package blackjack;

import java.util.*;

public class Main {

    public static void main(String[] args)
    {
        boolean game = true;
        Game start = new Game("Joost");

        //System.out.println("Welkom " + start.player.Name);
        //System.out.println("Let us play a game ");

        //System.out.println(start.Deck);
        System.out.println(start.player.Hand);

        //start.addCard();
    }
}
