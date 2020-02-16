using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    class Room : BaseEntity
    {
        public Room(int capacity, string type,double adultPrice, double childPrice, int number)
        {
            this.Capacity = capacity;
            this.Type = type;
            this.AdultPrice = adultPrice;
            this.ChildPrice = childPrice;
            this.Number = number;
        }

        public int Capacity { get; set; }

        public string Type { get; set; }

        public double AdultPrice { get; set; }

        public double ChildPrice { get; set; }

        public int Number { get; set; }

    }
}
