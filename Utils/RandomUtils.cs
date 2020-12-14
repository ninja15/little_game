﻿using System;
namespace Utils
{
    public static class RandomUtils
    {
        static Random random = new Random(100);

        public static int Percentage()
        {
            return random.Next(1, 100 + 1);
        }

        public static int Dice(int sides)
        {
            return random.Next(1, sides + 1);
        }
    }
}
