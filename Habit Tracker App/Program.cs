using HabitTracker.Domains;
using HabitTracker.Services;
using System;
using System.Collections.Generic;

namespace HabitTracker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            string pass = Console.ReadLine();
            User loggedUser = new User();
            loggedUser.UserName = userName;
            loggedUser.Password = pass;
            AplicationServices services = new AplicationServices();

            bool logedInUser = services.LogIn(loggedUser);
            if (logedInUser)
            {
                Console.WriteLine($"User {loggedUser.UserName} is logged in.");
            }
            else
            {
                Console.WriteLine("Sorry no such user");
            }

            Console.WriteLine("Please enter username to get all the habits for that user:");
            string userUserName = Console.ReadLine();
            User nextUser = new User();
            nextUser.UserName = userUserName;
            List<User> users = new List<User>() 
            {  loggedUser, nextUser };
            services.GetUserHabbits(nextUser);

            Console.WriteLine("Plesae enter 1 to create new user:");

            string newUserChoice = Console.ReadLine();

            if (newUserChoice == "1")
            {
                User newUser = services.AddNewUser("mikeWw1", "123456", "Mike", "Wayne", DateTime.Now);
            }

            Console.ReadLine();
        }
    }
}