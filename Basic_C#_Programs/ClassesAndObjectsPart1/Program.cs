using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Roger", "Mick", "Eric" };
            game.ListPlayers();
            Console.ReadLine();



            //Polymorphism
            //List<Game> games = new List<Games>();
            //Game game = new TwentyOneGame();
            //games.Add(games);
            //PokerGame
            //SolitareGame

            Deck deck = new Deck();
            deck.Shuffle(3);


            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
            //}

            //public static Deck Shuffle(Deck deck, int times = 1) 
            //{
            //for (int i = 0; i < times; i++) ;
            //{
            //    deck = Shuffle(deck);
            //}
            //  return deck;
        }
   }
}
