using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FoxKing
{
    public class Population
    {
        public static Population empty = new Population { knight = 0, peasent = 0, spearman = 0 };

        public int knight { get; set; }
        public int peasent { get; set; }
        public int spearman { get; set; }

        public override string ToString()
        {
            return String.Format("Крестьяне: {0}, копейщики: {1}, рыцари: {2}",
                                 peasent, spearman, knight);
        }
    }

    public class Kingdom
    {
        public Kingdom(int k, int p, int s, int m)
        {
            population = new Population { knight = k, peasent = p, spearman = s };
            money = m;
        }

        public int money { get; set; }
        public Population population { get; set; }

        public override string ToString()
        {
            return string.Format("{0}; Деньги: {1}", population, money);
        }

        public bool isAlive()
        {
            if (population == Population.empty || money <= 0)
                return false;
            else
                return true;
        }
    }
};
