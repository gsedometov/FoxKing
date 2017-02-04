using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxKing
{
    class Program
    {
        public static void Main(string[] args)
        {
            var kingdom = new Kingdom(2, 4, 3, 1000);
            var result = GameLogic.Step(kingdom);
            Console.WriteLine(kingdom.ToString() + '\n' + result.ToString());
        }
    }
}
