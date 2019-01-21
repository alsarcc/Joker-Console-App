using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotJokerW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Results Results = new Results();
            Results.AddPlayers(10);
            Results.ManyLotteries(5);
            Results.Statistics.MaxOccurrence();
            Results.Statistics.MinOccurrence();
        }
    }
}
