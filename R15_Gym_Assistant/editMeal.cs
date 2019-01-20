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
    public partial class editMeal : Form
    {
        public editMeal()
        {
            InitializeComponent();
        }
        
        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void editWorkout_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //set connection
        private void SetConnection()
        {
            con = new SQLiteConnection("Data Source=dbGymAssistant.db; Version=3; New=False; Compress=True;");
        }

        //set executequery code
        private void ExecuteInsert(string txtQuery)
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
            string CommandText = "SELECT *FROM Prehrana";
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            con.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string txtQuery = "UPDATE Prehrana SET Obrok='" + textObrok.Text + "', KolProteina='" + textKolProteina.Text + "' WHERE ID='" + textID.Text + "' ";
            ExecuteInsert(txtQuery);
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string txtQuery = "DELETE FROM Prehrana WHERE ID='" + textID.Text + "'";
            ExecuteInsert(txtQuery);
            LoadData();
        }
    }
}
