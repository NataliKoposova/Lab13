using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class Building
    {
        string address;
        int length;
        int width;
        int height;
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public int Length
        {
            get
            {
                return length;
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
        }
        public Building(string address, int length, int width, int height)
        {
            this.address = address;
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public string Print() 
        {
            return $"Адресс здания: {address}, длина здания - {length} , ширина здания - {width}, высота здания - {height}";
        }
    }
}
