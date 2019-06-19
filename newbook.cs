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
    public partial class newbook : Form
    {
        public newbook()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string name, author, score, press, price, amount;
            name = textBoxName.Text;
            author = textBoxAuthor.Text;
            score = textBoxScore.Text;
            press = textBoxPress.Text;
            price = textBoxPrice.Text;
            amount = textBoxAmount.Text;
            string num;
            string connect = Form1.userlogin;
            string getnum = "select count(*) from book;";
            string add = "";
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(getnum, conn);
                try
                {
                    num = cmd.ExecuteScalar().ToString();
                    add = "insert into book(id, Bookname, Author, Score, Press, Price, Amount) values('" + num + "', '" + name + "', '" + author + "', '" + score + "', '" + press + "', '" + price + "', '" + amount + "');";
                    cmd = new MySqlCommand(add, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("插入完成，书ID:" + num, "完成");
                }
                catch
                {
                    MessageBox.Show(add, "错误");
                }
                finally
                {
                    this.Close();
                }
            }
        }

    }
}
