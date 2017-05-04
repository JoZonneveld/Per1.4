package blackjack;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;


public class Game
{

    public List<Cards> Deck;
    public IPlayer player;
    public IPlayer bot;

    public Game(String name)
    {
        this.player = new Player(name);
        this.bot = new Bot();
        this.Deck = CreateDeck();
    }

    public void StartGame()
    {
        //Start the game fill the players hand with 2 cards
        for(int i = 0; i < 2; i++)
        {
            this.DrawCard(this.player);
            this.DrawCard(this.bot);
        }
    }

    public void DrawCard(IPlayer DrawIPlayer)
    {
        int number = randomNumber(this.Deck);
    }

    public int randomNumber(List<Cards> deck)
    {
        List<Integer> random = new ArrayList<Integer>();

        for(int i = 0; i < deck.size(); i++)
        {
            random.add(i);
        }

        Random r = new Random();

        int number = random.get(r.nextInt(random.size()));

        Deck.remove(number);

        return number;

    }

    private List<Cards> CreateDeck()
    {
        List<Cards> deck = new ArrayList<Cards>(); //card deck

        //hearts
        deck.add(new Cards("Hearts", "Two", 2));
        deck.add(new Cards("Hearts", "Three", 3));
        deck.add(new Cards("Hearts", "Four", 4));
        deck.add(new Cards("Hearts", "Five", 5));
        deck.add(new Cards("Hearts", "Six", 6));
        deck.add(new Cards("Hearts", "Seven", 7));
        deck.add(new Cards("Hearts", "Eight", 8));
        deck.add(new Cards("Hearts", "Nine", 9));
        deck.add(new Cards("Hearts", "Ten", 10));
        deck.add(new Cards("Hearts", "Jack", 10));
        deck.add(new Cards("Hearts", "Queen", 10));
        deck.add(new Cards("Hearts", "King", 10));
        deck.add(new Cards("Hearts", "Ace", 11));

        // Diamond
        deck.add(new Cards("Diamond", "Two", 2));
        deck.add(new Cards("Diamond", "Three", 3));
        deck.add(new Cards("Diamond", "Four", 4));
        deck.add(new Cards("Diamond", "Five", 5));
        deck.add(new Cards("Diamond", "Six", 6));
        deck.add(new Cards("Diamond", "Seven", 7));
        deck.add(new Cards("Diamond", "Eight", 8));
        deck.add(new Cards("Diamond", "Nine", 9));
        deck.add(new Cards("Diamond", "Ten", 10));
        deck.add(new Cards("Diamond", "Jack", 10));
        deck.add(new Cards("Diamond", "Queen", 10));
        deck.add(new Cards("Diamond", "King", 10));
        deck.add(new Cards("Diamond", "Ace", 11));

        //Clubs
        deck.add(new Cards("Clubs", "Two", 2));
        deck.add(new Cards("Clubs", "Three", 3));
        deck.add(new Cards("Clubs", "Four", 4));
        deck.add(new Cards("Clubs", "Five", 5));
        deck.add(new Cards("Clubs", "Six", 6));
        deck.add(new Cards("Clubs", "Seven", 7));
        deck.add(new Cards("Clubs", "Eight", 8));
        deck.add(new Cards("Clubs", "Nine", 9));
        deck.add(new Cards("Clubs", "Ten", 10));
        deck.add(new Cards("Clubs", "Jack", 10));
        deck.add(new Cards("Clubs", "Queen", 10));
        deck.add(new Cards("Clubs", "King", 10));
        deck.add(new Cards("Clubs", "Ace", 11));

        //Spades
        deck.add(new Cards("Spades", "Two", 2));
        deck.add(new Cards("Spades", "Three", 3));
        deck.add(new Cards("Spades", "Four", 4));
        deck.add(new Cards("Spades", "Five", 5));
        deck.add(new Cards("Spades", "Six", 6));
        deck.add(new Cards("Spades", "Seven", 7));
        deck.add(new Cards("Spades", "Eight", 8));
        deck.add(new Cards("Spades", "Nine", 9));
        deck.add(new Cards("Spades", "Ten", 10));
        deck.add(new Cards("Spades", "Jack", 10));
        deck.add(new Cards("Spades", "Queen", 10));
        deck.add(new Cards("Spades", "King", 10));
        deck.add(new Cards("Spades", "Ace", 11));

        return deck;
    }
}


