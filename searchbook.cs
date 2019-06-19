using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class searchbook : Form
    {
        public searchbook()
        {
            InitializeComponent();
        }

        public static string Bookname, Author, Score, Press, Price, Amount, ID;
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string connect = Form1.userlogin;
            MySqlConnection conn;
            ID = textBoxID.Text;
            string check;
            int tag = 0;
            string checkID = "select id from book where id = '" + ID + "';";
            string getName = "select Bookname from book where id = '" + ID + "';";
            string getAuthor = "select Author from book where id = '" + ID + "';";
            string getScore = "select Score from book where id = '" + ID + "';";
            string getPress = "select Press from book where id = '" + ID + "';";
            string getPrice = "select Price from book where id = '" + ID + "';";
            string getAmount = "select Amount from book where id = '" + ID + "';";
            using (conn = new MySqlConnection(connect))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(getName, conn);
                try
                {
                    MySqlCommand ch = new MySqlCommand(checkID, conn);
                    check = ch.ExecuteScalar().ToString();
                    tag = 1;
                    Bookname = cmd.ExecuteScalar().ToString();
                    cmd = new MySqlCommand(getAuthor, conn);
                    Author = cmd.ExecuteScalar().ToString();
                    cmd = new MySqlCommand(getScore, conn);
                    Score = cmd.ExecuteScalar().ToString();
                    cmd = new MySqlCommand(getPress, conn);
                    Press = cmd.ExecuteScalar().ToString();
                    cmd = new MySqlCommand(getPrice, conn);
                    Price = cmd.ExecuteScalar().ToString();
                    cmd = new MySqlCommand(getAmount, conn);
                    Amount = cmd.ExecuteScalar().ToString();
                    updateBook update = new updateBook();
                    this.Hide();
                    update.ShowDialog();
                    this.Show();
                }
                catch
                {
                    if (tag == 0)
                        MessageBox.Show("未找到图书", "错误");
                    else MessageBox.Show("未知错误");
                }
                return;
            }
        }
    }
}
