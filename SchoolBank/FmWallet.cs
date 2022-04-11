using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolBank
{
    public partial class FmWallet : Form
    {
        public FmWallet()
        {
            InitializeComponent();
            dataGridView1.Show();
        }

        private void rbDeposit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void show_btn_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            DateTime StartDate = DateTime.Today.AddDays(-7);
            string strStart = StartDate.ToString("MM/dd/yyyy");
            DateTime EndDate = DateTime.Today;
            string strEnd = EndDate.ToString("MM/dd/yyyy");
            string SQL = "SELECT Name, TDate, TType, Amount FROM Transactions ";

            Cmd.CommandText = SQL;
            OleDbDataAdapter da = new OleDbDataAdapter(Cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            Conn.Close();
            dataGridView1.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "SELECT * FROM Accounts ";

            Cmd.CommandText += " WHERE Username ='hi'";
            OleDbDataReader reader = Cmd.ExecuteReader();//Runs the query & allows results to be read.
            if (reader.HasRows) //if a record is found display details
            {
                reader.Read();//Read the first record found
                lbBalance.Text = "£" + String.Format("{0:N2}", reader["Holdings"]);
            }
            else
            {
                MessageBox.Show("Student ID not found - please check");
            }
            reader.Close();
            Conn.Close();
        }
    }
}
