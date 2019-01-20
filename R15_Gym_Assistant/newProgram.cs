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
    public partial class newProgram : Form
    {
        public newProgram()
        {
            InitializeComponent();
        }
        
        private void newProgram_Load(object sender, EventArgs e)
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
        private long ExecuteQuery(string txtQuery)
        {
            SetConnection();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = txtQuery;
            cmd.ExecuteNonQuery();

            var cmd2 = con.CreateCommand();
            cmd2.CommandText = @"select last_insert_rowid()";
            var id = (long)cmd2.ExecuteScalar();

            con.Close();
            return id;
        }

        //load DB
        private void LoadData()
        {
            SetConnection();
            con.Open();
            cmd = con.CreateCommand();
            string CommandText = "SELECT *FROM Program";
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            con.Close();
        }
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string txtQuery = "INSERT INTO Program(ID, Naziv, PutaTjedno)VALUES('" + textID.Text + "','" + textNaziv.Text + "','" + textTjedno.Text + "')";

            var id = ExecuteQuery(txtQuery);
            LoadData();

            DialogResult result = MessageBox.Show("Program treninga dodan!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                newWorkout workout = new newWorkout();
                workout.id_programa = id;
                new_program pick = new new_program();
                pick.ShowDialog();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string txtQuery = "DELETE FROM Program WHERE ID='" + textID.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textNaziv.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textTjedno.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new_program naknadno = new new_program();
            naknadno.ShowDialog();
        }
    }
}
