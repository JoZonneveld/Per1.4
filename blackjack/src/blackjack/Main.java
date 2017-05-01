package blackjack;

import java.util.*;

public class Main {

    public static void main(String[] args)
    {
        boolean game = true;
        Game start = new Game();


        while(true)
        {
            System.out.println(start.RandomList);
            int number = start.GetRandomNumber();
            System.out.println(number);
            System.out.println(start.RandomList);
        }



    }
}
