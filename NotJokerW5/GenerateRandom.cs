using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotJokerW5
{
    interface GenerateRandom
    {
        int Joker { get; set; }
        List<int> DrawList { get; set; }

        List<int> GenetateDrawListRandom(Random r);
        int GenerateJokerRandom(Random r);
    }
}
