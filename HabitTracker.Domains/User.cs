using System;

namespace HabitTracker.Domains
{
    public class User
    {
        public User(string userName, string pass, string firstName, string lastName, DateTime dateOfBirth)
        {
            UserName = userName;
            Password = pass;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            UsersHabits = new Habit[] { };
        }
        public User()
        {

        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Habit[] UsersHabits { get; set; }





    }
}
