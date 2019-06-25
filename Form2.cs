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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static int tag;


        private void Form2_Load_1(object sender, EventArgs e)
        {
            //  panelReturn.Hide();
            panelRe.Hide();
            panelPasswd.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tag = 0;
        }

        private void ChangeInfo_Click(object sender, EventArgs e)
        {
            AccountInfo change = new AccountInfo();
            change.Show();
        }

        private void 管理员工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
            if (String.Equals(Form1.role, "Users"))
            {
                MessageBox.Show("您不是管理员！", "错误");
                return;
            }
            管理员工具 admin = new 管理员工具();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            panelReturn.Show();
            panelRe.Hide();
            textBoxID.Text = "";
            textBoxPasswd.Text = "";
            string connectString = "server=localhost;User Id=root;password=password;Database=library;";
            string sql = string.Format("select Id, bookName, author, score, press, price, amount from book where bookName like '%" + textBoxBookName.Text.Trim() + "%'");
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connectString);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            this.SearchBookDataGridView.DataSource = dt;
        }

        private void clear()
        {
            textBoxBookName.Text = "";
            textBoxID.Text = "";
            textBoxPasswd.Text = "";
        }

        private void ChangeInfo_Click_1(object sender, EventArgs e)
        {
            clear();
            AccountInfo change = new AccountInfo();
            change.Show();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            textBoxBookName.Text = "";
            textBoxPasswd.Text = "";
            string num;
            string connect = "server=localhost;User Id=root;password=password;Database=library;";
            string getNum = "select Amount from book where ID = '" + textBoxID.Text + "';";
            MySqlCommand cmd;
            MySqlConnection conn = new MySqlConnection(connect);
            using (conn)
            {
                conn.Open();
                cmd = new MySqlCommand(getNum, conn);
                num = cmd.ExecuteScalar().ToString();
                if (string.Equals(num, "0"))
                {
                    MessageBox.Show("抱歉，此书暂无库存", "提示");
                    return;
                }
                else
                {
                    string updateNum = "update book set Amount = '" + (Convert.ToInt32(num) - 1).ToString() + "' where id = '" + textBoxID.Text + "';";
                    string insertBorrow = "insert into Ub(Uno, id, BorrowTime, BackTime) values('" + Form1.userid + "', '" + textBoxID.Text + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.AddMonths(1).ToString("yyyy-MM-dd") + "');";
                    try
                    {
                        cmd = new MySqlCommand(updateNum, conn);
                        cmd.ExecuteNonQuery();
                        cmd = new MySqlCommand(insertBorrow, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("借书成功", "提示");
                        string sql = string.Format("select Id, bookName, author, score, press, price, amount from book where bookName like '%" + textBoxBookName.Text.Trim() + "%'");
                        MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connect);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        this.SearchBookDataGridView.DataSource = dt;
                        return;
                    }
                    catch
                    {
                        MessageBox.Show("借书失败", "提示");
                        return;
                    }
                }
            }
        }

        private void MyBook_Click(object sender, EventArgs e)
        {
            clear();
            panelRe.Show();
            string connect = "server=localhost;User Id=root;password=password;Database=library;";
            string getBooks = string.Format("select id, Bookname, Author, Score, Press, Price from book where id in (select id from Ub where Uno = '" + Form1.userid + "');");
            MySqlConnection conn = new MySqlConnection(connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(getBooks, connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            this.dataGridViewReturn.DataSource = dt;
            panelReturn.Show();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            string connect = "server=localhost;User Id=root;password=password;Database=library;";
            string getID = "select id from Ub where id = '" + textBoxReturn.Text + "' and Uno = '" + Form1.userid + "';";
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                conn.Open();
                string ID = "";
                MySqlCommand cmd = new MySqlCommand(getID, conn);
                try
                {
                    ID = cmd.ExecuteScalar().ToString();
                }
                catch
                {
                    MessageBox.Show("您没有借阅此图书" + ID, "提示");
                    return;
                }
                string getNum = "select Amount from book where ID = '" + textBoxReturn.Text + "';";
                cmd = new MySqlCommand(getNum, conn);
                string num = cmd.ExecuteScalar().ToString();
                string update = "delete from Ub where Uno = '" + Form1.userid + "' and id = '" + textBoxReturn.Text + "';" + "update book set Amount = '" + (Convert.ToInt32(num) + 1).ToString() + "' where id = '" + textBoxReturn.Text + "'; ";
                cmd = new MySqlCommand(update, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("还书成功", "提示");
                    string getBooks = string.Format("select id, Bookname, Author, Score, Press, Price from book where id in (select id from Ub where Uno = '" + Form1.userid + "');");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(getBooks, connect);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    this.dataGridViewReturn.DataSource = dt;
                    return;
                }
                catch
                {
                    MessageBox.Show("还书失败", "错误");
                }
            }
        }

        private void deleteAccount_Click(object sender, EventArgs e)
        {
            clear();
            string connect = "server=localhost;User Id=root;password=password;Database=library;";
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                conn.Open();
                string num;
                string getNum = "select count(*) from Ub where Uno = '" + Form1.userid + "';";
                MySqlCommand cmd = new MySqlCommand(getNum, conn);
                try
                {
                    num = cmd.ExecuteScalar().ToString();
                }
                catch
                {
                    MessageBox.Show("未知错误", "错误");
                    return;
                }
                if(!string.Equals(num, "0"))
                {
                    MessageBox.Show("您尚有未归还图书，不能删除账户", "提示");
                    return;
                }
                MessageBox.Show("若要删除账户，请输入密码", "提示");
                panelPasswd.Show();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string connect = "server=localhost;User Id=root;password=password;Database=library;";
            string drop = "delete from " + Form1.role + " where Uno = '" + Form1.userid + "'; drop user '" + Form1.userid + "'@'localhost';";
            string getPasswd = "select Upasswd from " + Form1.role + " where Uno = '" + Form1.userpasswd + "';";
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                conn.Open();
                if(!String.Equals(Form1.userpasswd, textBoxPasswd.Text))
                {
                    MessageBox.Show("密码错误", "提示");
                    return;
                }
                DialogResult result = MessageBox.Show("确定删除账户？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    MySqlCommand cmd = new MySqlCommand(drop, conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK);
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("删除失败", "错误");
                    }
                    panelPasswd.Hide();
                    return;
                }
                else
                {
                    panelPasswd.Hide();
                    return;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            panelPasswd.Hide();
        }

        private void SearchBookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = SearchBookDataGridView.Rows[e.RowIndex].Cells["id"].Value.ToString();
        }

        private void dataGridViewReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxReturn.Text = dataGridViewReturn.Rows[e.RowIndex].Cells["id"].Value.ToString();
        }
    }
}
