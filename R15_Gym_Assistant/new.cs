using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace R15_Gym_Assistant
{
    public partial class new_program : Form
    {
        public new_program()
        {
            InitializeComponent();
        }

        private void buttonTraining_Click(object sender, EventArgs e)
        {
            this.Hide();
            newWorkout work = new newWorkout();
            work.ShowDialog();
        }

        private void buttonMeal_Click(object sender, EventArgs e)
        {
            this.Hide();
            newMeal meal = new newMeal();
            meal.ShowDialog();
        }
    }
}
