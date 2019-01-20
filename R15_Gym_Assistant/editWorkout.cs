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
    public partial class editWorkout : Form
    {
        public editWorkout()
        {
            InitializeComponent();
        }

        private void editWorkout_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

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

        //load DB
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string txtQuery = "UPDATE Workouts SET Naziv='" + textNaziv.Text + "', DioTijela='" + textDioTijela.Text + "', BrojSerija='" + textBrojSerija.Text + "', BrojPonavljanja='" + textBrojPonavljanja.Text + "', Naputak='" + textNaputak.Text + "'  WHERE ID='" + textID.Text + "' ";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string txtQuery = "DELETE FROM Workouts WHERE ID='" + textID.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }
    }
}
