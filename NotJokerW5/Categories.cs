using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotJokerW5
{
    class Categories
    {
        public List<int> FiveAndOne;
        public double BudgetFiveAndOne;

        public List<int> Five;
        public double BudgetFive;

        public List<int> FourAndOne;
        public double BudgetFourAndOne;

        public List<int> Four;
        public double BudgetFour;

        public List<int> ThreeAndOne;
        public double BudgetThreeAndOne;

        public List<int> Three;
        public double BudgetThree;

        public List<int> TwoAndOne;
        public double BudgetTwoAndOne;

        public List<int> Two;
        public double BudgetTwo;

        public List<int> OneAndOne;
        public double BudgetOneAndOne;

        public List<int> OneAndZero;

        public List<int> Zero;

        public Categories()
        {
            FiveAndOne = new List<int>();
            BudgetFiveAndOne = Math.Round(Lottery.Budget * 0.4);

            Five = new List<int>();
            BudgetFive = Math.Round(Lottery.Budget * 0.25);

            FourAndOne = new List<int>();
            BudgetFourAndOne = Math.Round(Lottery.Budget * 0.15);

            Four = new List<int>();
            BudgetFour = Math.Round(Lottery.Budget * 0.05);

            ThreeAndOne = new List<int>();
            BudgetThreeAndOne = Math.Round(Lottery.Budget * 0.05);

            Three = new List<int>();
            BudgetThree = Math.Round(Lottery.Budget * 0.04);

            TwoAndOne = new List<int>();
            BudgetTwoAndOne = Math.Round(Lottery.Budget * 0.035);

            Two = new List<int>();
            BudgetTwo = Math.Round(Lottery.Budget * 0.015);

            OneAndOne = new List<int>();
            BudgetOneAndOne = Math.Round(Lottery.Budget * 0.01);

            OneAndZero = new List<int>();

            Zero = new List<int>();
        }
    }
}
