using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _hometask_AccessModifiresPart2
{
    public class ChinaCity : City
    {
        public ChinaCity(string name, int population) : base(name, population)
        {
            if (population <= 100000)
            {
                Console.WriteLine("1.000.000 asagi deyer daxil etmeyin.");
                return;
            }
            else
            {
                Name = name;
                Population = population;
            }
        }
    }
}
