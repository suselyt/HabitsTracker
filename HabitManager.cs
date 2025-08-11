using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Habits
{
    public class HabitManager
    {
        private readonly string _filepath = 
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "habits.json");
        public List<Habit> Habits { get; private set; }

        public HabitManager()
        {
            Habits = LoadHabits();
        }

        public List<Habit> LoadHabits()
        {
            if (!File.Exists(_filepath))
                return new List<Habit>();

            string json = File.ReadAllText(_filepath);
            return JsonSerializer.Deserialize<List<Habit>>(json);
        }

        public void SaveHabits()
        {
            string json = JsonSerializer.Serialize(Habits, new JsonSerializerOptions { WriteIndented = true});
            File.WriteAllText(_filepath, json);
        }

        public void AddHabit(Habit habit)
        {
            Habits.Add(habit);
            SaveHabits();
        }

        public void DeleteHabit(Habit habit)
        {
            Habits.Remove(habit);
            SaveHabits();
        }

        public void EditHabit(string habitId, Habit habitUpdated)
        {
            int index = Habits.FindIndex(h => h.Id == habitId);
            if (index == -1) return;

            habitUpdated.Id = Habits[index].Id;

            Habits[index] = habitUpdated;
            SaveHabits();
        }
    }
}
