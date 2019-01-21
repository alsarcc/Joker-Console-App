using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotJokerW5
{
    class Check
    {
        public static bool CheckForDuplicates145(List<int> list,int number)
        {
            if (number > 45 || number < 1)
                return false;
            else if (list.Contains(number))
                return false;
            else
            {
                list.Add(number);
                return true;
            }
        }
    }
}
