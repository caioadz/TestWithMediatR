using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploDDD.Domain.Entity
{
    public class User
    {
        public Guid? ID { get; set; }
        public FullName FullName { get; set; }
        public string Email { get; set; }
        public Password Password { get; set; }

        public User(string firstName, string lastName, string email, string password)
        {
            FullName = new FullName() { FirstName = firstName, LastName = lastName };
            Email = email;
            Password = new Password(password);
        }
    }
}
