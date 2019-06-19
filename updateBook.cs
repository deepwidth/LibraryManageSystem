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
    public partial class updateBook : Form
    {
        public updateBook()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string connect = Form1.userlogin;
            MySqlConnection conn;
            string update = "update book set Bookname = '" + textBoxBookname.Text + "', Author = '" + textBoxAuthor.Text + "', Score = '" + textBoxScore.Text + "', Press = '" + textBoxPress.Text + "', Price = '" + textBoxPrice.Text + "', Amount = '" + textBoxAmount.Text + "' where id = '" + searchbook.ID + "';";
            using (conn = new MySqlConnection(connect))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(update, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改成功", "提示");
                }
                catch
                {
                    MessageBox.Show("修改失败", "错误");
                    return;
                }
                this.Close();
            }
        }

        private void updateBook_Load(object sender, EventArgs e)
        {
            labelID.Text = searchbook.ID;
            textBoxBookname.Text = searchbook.Bookname;
            textBoxAuthor.Text = searchbook.Author;
            textBoxScore.Text = searchbook.Score;
            textBoxPress.Text = searchbook.Press;
            textBoxPrice.Text = searchbook.Price;
            textBoxAmount.Text = searchbook.Amount;
        }
    }
}
