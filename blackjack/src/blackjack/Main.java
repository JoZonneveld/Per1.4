package blackjack;

import java.util.*;

public class Main {

    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Vul uw naam in:");
        String name =(scanner.next());
        boolean game = true;
        Game start = new Game(name);

        System.out.println("Welkom " + start.player.Name);
        System.out.println("Let us play a game ");

        start.StartGame();

        start.player.CheckHand();


        System.out.println(start.player.Hand.get(0).kind + " " + start.player.Hand.get(0).number);
        System.out.println(start.player.Hand.get(1).kind + " " + start.player.Hand.get(1).number);



        while (game)
        {
            System.out.println("Wilt u nog een kaart? (y/n)");
            char kaart =(scanner.next().charAt(0));

            if(kaart == 'y')
            {
                start.DrawCard();
                System.out.println(start.player.CheckHand());
            }
            else if(kaart == 'n')
            {
                game = false;
            }
            else
            {
                System.out.println("U moet y of n invoeren ");
            }
        }
    }
}
