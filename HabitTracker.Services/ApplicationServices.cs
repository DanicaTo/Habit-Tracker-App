using System;
using System.Collections.Generic;
using HabitTracker.Domains;

namespace HabitTracker.Services
{
    public class AplicationServices
    {
       
        List<User> applicationUsers = new List<User>()
        {
            new User("steveBest", "1234567", "Steven", "Madden", DateTime.Now)
        };

        Habit[] usersHabits = new Habit[] { new Habit("creativity", Domains.Enums.HabitGroup.HomeAndPersonal) };
        

        public bool LogIn(User user)
        {
            if (user.UserName.Length < 6) return false;
            if (user.Password.Length < 6) Console.WriteLine("Password is too short");
            foreach (var person in applicationUsers)
            {
                if (person.UserName == user.UserName && person.Password == user.Password)
                {
                    return true;
                }
            }
            return false;
        }

        public void GetUserHabbits(User user)
        {
            foreach (var habbit in user.UsersHabits)
            {
                if (habbit.HabitGroup == Domains.Enums.HabitGroup.StudyAndLearning)
                {


                    Console.WriteLine(habbit.HabitTitle);
                }


            }

        }

        public User AddNewUser(string userName, string pass, string firstName, string lastName, DateTime dateOfBirth)
        {
            User user = new User();
            user.UserName = userName;
            user.Password = pass;
            user.FirstName = firstName;
            user.LastName = lastName;
            user.DateOfBirth = dateOfBirth;
            applicationUsers.Add(user);
            return user;
        }


    }
}