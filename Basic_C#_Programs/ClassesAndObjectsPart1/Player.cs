using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsPart1
{
    public class Player
    {
        public Player(string name, int beginningBalance) 
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool IsActivelyPlaying { get; set; }

        public static Game operator +(Game game, Player player) 
        {
            game.Players.Add(player);
            return game;
        }
    
    
    }
}
