using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolBank
{
    public partial class FmSettings : Form
    {
        public FmSettings()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void surname_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            string SQL = "INSERT INTO Accounts";  //Construct the INSERT command
            SQL += " VALUES('','', '', '', '"+ class_cb.Text +"')";
            Cmd.CommandText = SQL;
            Cmd.ExecuteNonQuery();
            Conn.Close();

        }


        private void studId_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "UPDATE Accounts SET Holdings = 0";
            Cmd.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
