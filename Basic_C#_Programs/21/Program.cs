using System;
using System.Collections.Generic;

namespace Blackjack
{
    class Program
    {
        // Entry point of the program.
        static void Main(string[] args)
        {
            // Prints a welcome message to the console.
            Console.WriteLine("Welcome to Blackjack!");

            // Prints a message indicating that cards are being dealt.
            Console.WriteLine("Dealing cards...");

            // Creates the deck of cards.
            List<string> deck = CreateDeck();

            // Shuffles the deck of cards.
            ShuffleDeck(deck);

            // Deals two cards to the player.
            List<string> playerCards = DealCards(deck, 2);

            // Deals two cards to the dealer.
            List<string> dealerCards = DealCards(deck, 2);

            // Prints to the screen the players cards.
            Console.WriteLine("Your cards are: " + string.Join(", ", playerCards));

            // Prints to the screen the players cards the dealer's cards.
            Console.WriteLine("The dealer's up card is: " + dealerCards[0]);

            // Calculates the player's score.
            int playerScore = CalculateScore(playerCards);

            // Calculates the dealer's score.
            int dealerScore = CalculateScore(dealerCards);

            // Flags indicating if it's the player's turn.
            bool playerTurn = true;

            // Loop to allow the player to hit or stand.
            while (playerTurn)
            {
                // Prints the player's current score to the screen.
                Console.WriteLine("Your current score is: " + playerScore);

                // Prompts the player to hit or stand.
                Console.WriteLine("Do you want to hit or stand? (h/s)");

                // Reads the player's action from the console.
                string playerAction = Console.ReadLine();

                // If the player hits.
                if (playerAction == "h")
                {
                    // Adds the next card from the deck to the player's hand.
                    playerCards.Add(deck[0]);
                    deck.RemoveAt(0);

                    // Recalculates the player's score.
                    playerScore = CalculateScore(playerCards);

                    // If the player busts.
                    if (playerScore > 21)
                    {
                        // Prints a message indicating that the player busts.
                        Console.WriteLine("You busted with a score of " + playerScore + "!");

                        // Ends the player's turn.
                        playerTurn = false;
                    }
                }
                // If the player stands.
                else if (playerAction == "s")
                {
                    // Ends the player's turn.
                    playerTurn = false;
                }
            }

            // Prints the dealer's cards to the console.
            Console.WriteLine("The dealer's cards are: " + string.Join(", ", dealerCards));

            // Loops for the dealer's turn.
            while (dealerScore < 17)
            {
                // Adds the next card from the deck to the dealer's hand.
                dealerCards.Add(deck[0]);
                deck.RemoveAt(0);

                // Recalculates the dealer's score.
                dealerScore = CalculateScore(dealerCards);

                Console.WriteLine("The dealer's score is now: " + dealerScore);
            }

            if (dealerScore > 21)
            {
                Console.WriteLine("The dealer busted with a score of " + dealerScore + "!");
                Console.WriteLine("You win!");
            }
            else if (dealerScore > playerScore)
            {
                Console.WriteLine("The dealer wins with a score of " + dealerScore + "!");
            }
            else if (dealerScore < playerScore)
            {
                Console.WriteLine("You win with a score of " + playerScore + "!");
            }
            else
            {
                Console.WriteLine("The game is a draw!");
            }

            Console.WriteLine("Thanks for playing Blackjack!");
            Console.ReadLine();
        }

        static List<string> CreateDeck()
        {
            // Creates a new list to store the deck of cards.
            List<string> deck = new List<string>();

            // Array to store the different suits.
            string[] suits = new string[] { "hearts", "diamonds", "spades", "clubs" };

            // Array to store the different values of cards.
            string[] values = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace" };

            // Loop through each suit.
            foreach (string suit in suits)
            {
                // Loop through each value.
                foreach (string value in values)
                {
                    // Adds the combination of value and suit to the deck list.
                    deck.Add(value + " of " + suit);
                }
            }

            // Returns the complete deck of cards.
            return deck;
        }

        static void ShuffleDeck(List<string> deck)
        {
            // Creates a new Random object.
            Random rng = new Random();

            // Gets the count of elements in the deck list.
            int n = deck.Count;

            // Shuffles the deck while n > 1.
            while (n > 1)
            {
                // Decrement n by 1.
                n--;

                // Gets a random index within the range of the current count of elements.
                int k = rng.Next(n + 1);

                // Stores the value of the card at index k.
                string value = deck[k];

                // Swap the value at index k with the value at index n
                deck[k] = deck[n];
                deck[n] = value;
            }
        }

        static List<string> DealCards(List<string> deck, int numberOfCards)
        {
            // Gets a range of cards from the deck list.
            List<string> dealtCards = deck.GetRange(0, numberOfCards);
            deck.RemoveRange(0, numberOfCards);
            return dealtCards;
        }

        static int CalculateScore(List<string> cards)
        {
            int score = 0;
            // "Foreach" loop
            foreach (string card in cards)
            {
                if (card.StartsWith("jack") || card.StartsWith("queen") || card.StartsWith("king"))
                {
                    score += 10;
                }
                // "Else if" statement
                else if (card.StartsWith("ace"))
                {
                    if (score + 11 > 21)
                    {
                        score += 1;
                    }
                    else
                    {
                        score += 11;
                    }
                }
                else
                {
                    score += int.Parse(card.Split(" ")[0]);
                }
            }
            return score;
        }
    }
}