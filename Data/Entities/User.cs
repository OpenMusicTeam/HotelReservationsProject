using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    class User : BaseEntity
    {
        public User(string username, string password, string firstName, string lastName, string uid, 
            string phoneNumber, string email, DateTime dateOfAppointment, bool isActive, bool isAdministrator)
        {
            this.Username = username;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UID = uid;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.DateOfAppointment = dateOfAppointment;
            this.IsActive = isActive;
            this.IsAdministrator = isAdministrator;

        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UID { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfAppointment  { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateOfDismissal { get; set; }
        public bool IsAdministrator { get; set; }
    }
}
