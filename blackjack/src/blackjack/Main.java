package blackjack;

import java.util.*;

public class Main {

    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Vul uw naam in:");
        String name =(scanner.next());
        boolean MainGame = true;
        boolean game = true;

        Game start = new Game(name);
        start.StartGame();
        System.out.println(start.bot.CheckHand());



//        while (MainGame)
//        {
//            Game start = new Game(name);
//            System.out.println("Welkom " + start.player.Name);
//            System.out.println("Let us play a game ");
//
//            start.StartGame();
//
//            while (game)
//            {
//                for(int i = 0; i < start.player.Hand.size(); i++)
//                {
//                    System.out.println(start.player.Hand.get(i).kind + " " + start.player.Hand.get(i).number);
//                }
//
//                System.out.println(start.player.CheckHand());
//
//                if(start.player.CheckHand() == 21)
//                {
//                    System.out.println("U wint!!");
//                    break;
//                }
//                else if(start.player.CheckHand() > 21)
//                {
//                    System.out.println("U verliest");
//                    break;
//                }
//                else {
//
//                    System.out.println("Wilt u nog een kaart? (y/n)");
//                    char kaart = (scanner.next().charAt(0));
//
//                    if (kaart == 'y') {
//                        start.DrawCard();
//                    } else if (kaart == 'n') {
//                        game = false;
//                    } else {
//                        System.out.println("U moet y of n invoeren ");
//                    }
//                }
//            }
//
//            System.out.println("Wilt u nog een game spelen? (y/n)");
//            char again =(scanner.next().charAt(0));
//
//            if(again == 'n')
//            {
//                MainGame = false;
//            }
//        }

    }
}

