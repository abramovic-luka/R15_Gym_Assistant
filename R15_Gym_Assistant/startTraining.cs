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
    public partial class startTraining : Form
    {
        int micSeconds, seconds, minutes;

        public startTraining()
        {
            InitializeComponent();
        }

        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        
        private void startTraining_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetTime();
        }

        //set connection
        private void SetConnection()
        {
            con = new SQLiteConnection("Data Source=dbGymAssistant.db; Version=3; New=False; Compress=True;");
        }

        //set executequery code
        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = txtQuery;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //set loadDB
        private void LoadData()
        {
            SetConnection();
            con.Open();
            cmd = con.CreateCommand();
            string CommandText = "SELECT *FROM Workouts";
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            con.Close();
        }
        
        //timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            micSeconds++;

             if(micSeconds > 9)
             {
                seconds++;
                micSeconds = 0;
             }

             if (seconds > 59)
             {
                minutes++;
                seconds = 0;
             }

            DrawTime();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ResetTime();
            DrawTime();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void ResetTime()
        {
            micSeconds = 0;
            seconds = 0;
            minutes = 0;
        }
        private void DrawTime()
        {
            labelMinutes.Text = appendZero(minutes);
            labelSeconds.Text = appendZero(seconds);
            labelMicSeconds.Text = appendZero(micSeconds);
        }

        private string appendZero(double str)
        {
            if(str <= 9)
            {
                return "0" + str;
            }
            else
            {
                return str.ToString();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showWorkout show = new showWorkout();
            show.textID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            show.textNaziv.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            show.textDioTijela.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            show.textBrojSerija.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            show.textBrojPonavljanja.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            show.textNaputak.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            show.ShowDialog();
        }
    }
}
