using Habits;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Habits
{
    public partial class Form1 : Form
    {
        private readonly HabitManager _habitManager = new HabitManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.DataSource = _habitManager.Habits;
            checkedListBox1.DisplayMember = "Name";
            checkedListBox1.ValueMember = "Id";
        }

    }
}
