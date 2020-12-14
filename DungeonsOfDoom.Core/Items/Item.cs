using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsOfDoom.Core.Characters;

namespace DungeonsOfDoom.Core.Items
{
    public abstract class Item : ILuggable
    {
        public Item(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public abstract void Use(Player player);
    }
}
