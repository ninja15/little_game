using System;
using Utils;
namespace DungeonsOfDoom.Core.Characters
{
    public class Ogre : Monster
    {
        public Ogre() : base("Ogre", RandomUtils.Percentage() < 50 ? 10 : 20)
        {
        }
    }
}
