using System;
using System.Collections.Generic;
using System.Text;


namespace Data.Entities
{
    class Guest : BaseEntity
    {

        public Guest(string firstName, string lastName, string phoneNumber, string email, bool isAdult)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.IsAdult = isAdult;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public bool IsAdult { get; set; }
    }
}
