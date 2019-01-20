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
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
        }

        private void buttonTraining_Click(object sender, EventArgs e)
        {
            this.Hide();
            editWorkout editW = new editWorkout();
            editW.ShowDialog();
        }

        private void buttonMeal_Click(object sender, EventArgs e)
        {
            this.Hide();
            editMeal editM = new editMeal();
            editM.ShowDialog();
        }
    }
}
