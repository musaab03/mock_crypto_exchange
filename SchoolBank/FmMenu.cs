using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace SchoolBank
{
    public partial class FmMenu : Form
    {
        public FmMenu()
        {
            InitializeComponent();
            gbxPass.Hide();
            gbxreg.Hide();
            groupBox1.Show();
            gbxexchange.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void act_btn_Click(object sender, EventArgs e)
        {
            gbxexchange.Show();
            groupBox1.Hide();
        }

        private void transact_btn_Click(object sender, EventArgs e)
        {
            FmSettings FmSettings = new FmSettings();
            FmSettings.ShowDialog();
        }

        private void stats_btn_Click(object sender, EventArgs e)
        {
            FmWallet FmStats = new FmWallet();
            FmStats.ShowDialog();
        }

        private void FmMenu_Load(object sender, EventArgs e)
        {
            if (File.Exists("CryptoDB.accdb") == false)
            {
                ADOX.Catalog cat = new ADOX.Catalog();
                cat.Create(Program.ConnString);    
                OleDbConnection Conn = new OleDbConnection(Program.ConnString);
                Conn.Open();                    
                OleDbCommand Cmd = new OleDbCommand();  
                Cmd.Connection = Conn;

                Cmd.CommandText = "CREATE TABLE Accounts(Username VARCHAR(15),";
                Cmd.CommandText += " Passwrd VARCHAR(15), Email VARCHAR(35), Holdings MONEY, CurrencyType CHAR(1))";
                Cmd.ExecuteNonQuery();

                Cmd.CommandText = "CREATE TABLE Bitcoin(Price MONEY, PriceChange DATE)";
                Cmd.ExecuteNonQuery();

                Cmd.CommandText = "CREATE TABLE Ethereum(Price MONEY, Rate MONEY, PriceChange DATE)";
                Cmd.ExecuteNonQuery();

                Cmd.CommandText = "CREATE TABLE Dogecoin(Price MONEY, Rate MONEY, PriceChange DATE)";
                Cmd.ExecuteNonQuery();

                Cmd.CommandText = "CREATE TABLE Transactions(Name VARCHAR(20), TDate DATE, Amount MONEY, TType VARCHAR(5))";
                Cmd.ExecuteNonQuery();

                Conn.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "SELECT * FROM Accounts WHERE Username ='" + user_txt.Text + "'";
            OleDbDataReader reader = Cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string p = reader["Passwrd"].ToString();
                if (pass_txt.Text == p)
                {
                    MessageBox.Show("You're Logged In!");
                    groupBox1.Hide();
                    gbxPass.Hide();
                    gbxreg.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong password");
                }
            }
            else
            {
                MessageBox.Show("Invalid Login Details");
            }
            Conn.Close();
            Clear();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            

        }

        void Clear()
        {
            user_txt.Clear();
            pass_txt.Clear();
        }

        private void pass_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void user_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbxPass_Enter(object sender, EventArgs e)
        {

        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbxreg.Show();
        }

        private void quitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            gbxPass.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbxreg_Enter(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            gbxreg.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            gbxPass.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;

            if (userreg.Text != "")
            {
                if (passtext1.Text != "" && passtxt2.Text != "" && passtext1.Text == passtxt2.Text)
                {
                    if (emailreg.Text != "")
                    {
                        Cmd.CommandText = "INSERT INTO Accounts VALUES('" + userreg.Text + "', '" + passtext1.Text + "', '" + emailreg.Text + "', '#', '£')";
                        Cmd.ExecuteNonQuery();

                        Conn.Close();
                        MessageBox.Show("Registered!");
                        gbxreg.Hide();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Enter a valid email");
                    }
                }
                else if (passtext1.Text == "" || passtxt2.Text == "")
                {
                    MessageBox.Show("Enter a password");
                }
                else if (passtext1.Text != passtxt2.Text)
                {
                    MessageBox.Show("Passwords do not match");
                }

            }
            else
            {
                MessageBox.Show("Enter a username");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FmBitcoin FmBtc = new FmBitcoin();
            FmBtc.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            gbxexchange.Hide();
        }

        private void ethbtn_Click(object sender, EventArgs e)
        {
            FmBitcoin FmBtc = new FmBitcoin();
            FmBtc.ShowDialog();
        }

        private void dogebtn_Click(object sender, EventArgs e)
        {
            FmBitcoin FmBtc = new FmBitcoin();
            FmBtc.ShowDialog();
        }
    }
}
