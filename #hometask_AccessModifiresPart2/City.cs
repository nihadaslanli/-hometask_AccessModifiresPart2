﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _hometask_AccessModifiresPart2
{
    public class City
    {
        private string name;
        private int population;



        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Population
        {
            get
            {
                return population;
            }
            set
            {
                population = value;
            }
        }
        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }





    }


}


