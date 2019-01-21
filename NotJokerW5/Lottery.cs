using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotJokerW5
{
    class Lottery : GenerateRandom
    {
        public int ID { get; set; }
        public List<int> DrawList { get; set; }
        public int Joker { get; set; }
        public static double Budget { get; set; }
        public double RemainingBudget { get; set; }

        public Lottery(double previousBudget)
        {
            Random r = new Random(); //Created this Random inside the Constructor for shortcut

            ID = 0;
            DrawList = GenetateDrawListRandom(r);
            Joker = GenerateJokerRandom(r);
            Budget = 1000 + previousBudget;
            RemainingBudget = 0;
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
