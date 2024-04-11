using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class MultiBuilding : Building
    {
        int levels;

        public int Levels
        {
            get
            {
                return levels;
            }
            set
            {
                levels = value;
            }
        }
        public MultiBuilding(string address, int length, int width, int height, int levels)
            : base(address, length, width, height)
        {
            this.levels = levels;
        }

        public string Print()
        {
            string result=base.Print();
            result += $", кол-во этажей - {levels}";
            return result;
        }
    }
}