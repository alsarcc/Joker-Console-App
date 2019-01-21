using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotJokerW5
{
    class Player : GenerateRandom
    {
        public int ID { get; set; }
        public List<int> DrawList { get; set; }
        public int Joker { get; set; }
        public static double MoneyEarned { get; set; }

        public Player(Random r)
        {
            ID = 0;
            DrawList = GenetateDrawListRandom(r);
            Joker = GenerateJokerRandom(r);
            MoneyEarned = 0;
        }

        public List<int> GenetateDrawListRandom(Random r)
        {
            DrawList = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                if (!DrawList.Contains(r.Next(1, 46)))
                {
                    DrawList.Add(r.Next(1, 46));
                }
                else
                {
                    i--;
                }
            }
            return DrawList;
        }

        public int GenerateJokerRandom(Random r)
        {
            Joker = r.Next(1, 21);

            return Joker;
        }

    }
}
