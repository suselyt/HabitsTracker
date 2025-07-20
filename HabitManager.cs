using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habits
{
    public class HabitManager
    {
        private readonly string _filepath = "habits.json";
        public List<Habit> Habits { get; private set; }

        public HabitManager()
        {
            Habits = LoadHabits();
        }

        public List<Habit> LoadHabits()
        {
            if (!File.Exists(_filepath))
                return new List<Habit>();

            string
        }
    }
}
