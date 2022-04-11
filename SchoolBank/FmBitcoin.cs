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
    public partial class FmBitcoin : Form
    {
        public FmBitcoin()
        {
            InitializeComponent();
            lbDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 60000;
            timer.Elapsed += timer_Elapsed;
            timer.Start();
        }

        private void FmBitcoin_Load(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "SELECT * FROM Accounts ";
            Cmd.CommandText += " WHERE Username ='hi'";
            OleDbDataReader reader = Cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                lbbal.Text = "£" + String.Format("{0:N2}", reader["Holdings"]);
            }
            else
            {
                MessageBox.Show("Account not found");
            }

            reader.Close();
            Conn.Close();

        }

        static void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            double pricebtc = 0.01;
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;

            if (pricebtc > 0)
            {
                Random randprice = new Random();
                pricebtc = randprice.Next(10000, 100000);
                Cmd.CommandText = "INSERT INTO Bitcoin VALUES('" + pricebtc + "', '" + DateTime.Now + "')";
                Cmd.ExecuteNonQuery();
            }
        }

        private void BtcGraph()
        {
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "SELECT column1 , column2 FROM dbo.myTable";
            DataSet ds = new DataSet();

            OleDbDataAdapter da = new OleDbDataAdapter(Cmd);
            da.Fill(ds);
            this.btcgraph.DataSource = ds.Tables[0];

            //Mapping a field with x-value of chart
            this.btcgraph.Series[0].XValueMember = "column1";

            //Mapping a field with y-value of Chart
            this.btcgraph.Series[0].YValueMembers = "column2";

            //Bind the DataTable 
        }

        private void lbprice_Click(object sender, EventArgs e)
        {

        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            Single Balance = Convert.ToSingle(amount_txt.Text);
            string TType = "";
            if (rbSell.Checked)
            {
                Balance = Balance - Convert.ToSingle(amount_txt.Text);
                TType = "Sell";
            }
            else
            {
                Balance = Balance + Convert.ToSingle(amount_txt.Text);
                TType = "Buy";
            }
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "UPDATE Accounts SET Holdings =" + Convert.ToString(Balance);
            Cmd.CommandText += " WHERE StudentID ='hi'";
            Cmd.ExecuteNonQuery();
            Cmd.CommandText = "INSERT INTO Transactions ";
            Cmd.CommandText += " VALUES('hi', #" + lbDate.Text + "#, ";
            Cmd.CommandText += amount_txt.Text + ", '" + TType + "')";
            Cmd.ExecuteNonQuery();
            Conn.Close();
            MessageBox.Show("Order placed");
            ClearnHide();
        }

        void ClearnHide()
        {
            amount_txt.Clear();
        }

        private void btcgraph_Click(object sender, EventArgs e)
        {
            
        }
    }
}
