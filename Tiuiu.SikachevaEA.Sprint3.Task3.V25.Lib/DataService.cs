using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tiuiu.SikachevaEA.Sprint3.Task3.V25.Lib
{
    public class DataService : ISprint3Task3V25
    {
        public int GetMinCharCount(string value, char item)
        {
            int count = 1;
            foreach (char chr in value)
            {
                if (chr == 1)
                {
                    count++;
                }
                break;
            }
            return count;
        }
    }
}
