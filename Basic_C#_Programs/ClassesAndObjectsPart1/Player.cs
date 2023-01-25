using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsPart1
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balnce { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

    }
}
