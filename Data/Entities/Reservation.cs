using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    class Reservation : BaseEntity
    {
        public Reservation(Room reservedRoom, User reservator,List<Guest> guests, DateTime dateOfAccomodation, DateTime dateOfRelease,
            bool isBreakfastIncluded, bool isAllInclusive, double price)
        {
            this.ReservedRoom = reservedRoom;
            this.Reservator = reservator;
            this.Guests = guests;
            this.DateOfAccomodation = dateOfAccomodation;
            this.DateOfRelease = dateOfRelease;
            this.IsBreakfastIncluded = isBreakfastIncluded;
            this.IsAllInclusive = isAllInclusive;
            this.Price = price;
        }

        public Room ReservedRoom { get; set; }

        public User Reservator { get; set; }
        public List<Guest> Guests { get; set; }
        public DateTime DateOfAccomodation { get; set; }
        public DateTime DateOfRelease { get; set; }
        public bool IsBreakfastIncluded { get; set; }
        public bool IsAllInclusive { get; set; }
        public double Price { get; set; }

    }
}
