using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsOfDoom.Core.Items;

namespace DungeonsOfDoom.Core.Characters
{
    public class Player : Character
    {
        public Player(int health, int x, int y) : base(health)
        {
            X = x;
            Y = y;
            BackPack = new List<ILuggable>();
        }

        public int X { get; set; }
        public int Y { get; set; }
        public List<ILuggable> BackPack { get; set; }
    }
}
