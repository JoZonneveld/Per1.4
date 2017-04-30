package blackjack;

import java.util.*;

public class Main {

    public static void main(String[] args)
    {
        boolean game = true;
        Game start = new Game();

        List<Cards> deck = start.CreateDeck();
        List<Integer>random = start.randomNumber(deck);

        Random r = new Random();

        while(game)
        {
            int number = random.get(r.nextInt(random.size()));
            random.remove(number);
            System.out.println(number);

            System.out.println(random);
        }

    }
}
