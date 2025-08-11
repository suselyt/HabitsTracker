using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habits
{
    public class Habit
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = "";
        public string Category { get; set; } = "General";
        public string Time { get; set; }
        public string Repeat { get; set; }

    }
}
