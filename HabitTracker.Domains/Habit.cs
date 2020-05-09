using System;
using System.Collections.Generic;
using System.Text;


namespace HabitTracker.Domains
{
    public class Habit
    {
        public Habit (string habitTitle, Enums.HabitGroup habitGroup)
        {
            HabitTitle = habitTitle;
            HabitGroup = habitGroup;
        }
        public string HabitTitle { get; set; }
        public Enums.HabitGroup HabitGroup { get; set; }
        public User User { get; set; }
       // Habit badHabit = new Habit("lazyness", Enums.HabitGroup.HomeAndPersonal);
    }
}
