using System;

namespace FoxKing
{
    public static class GameLogic
    {
        private static Random random = new Random();

        public static int Dice()
        {
            return random.Next(6);
        }

        public static bool Step(Kingdom k)
        {
            switch (Dice())
            {
                case 0:
                    k.population.peasent += 1;
                    break;
                case 1:
                    k.population.spearman += 1;
                    break;
                case 2:
                    k.population.knight += 1;
                    break;
                case 3:
                    k.money += 500;
                    break;
                case 4:
                    int fee = k.money / 10;
                    k.money -= fee;
                    break;
                case 5:
                    k.money -= 1000;
                    break;
            }
            return k.isAlive();
        }
    }
}
