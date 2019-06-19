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
    public partial class 管理员工具 : Form
    {
        public 管理员工具()
        {
            InitializeComponent();
        }

        private void 新书入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newbook newbook = new newbook();
            this.Hide();
            newbook.ShowDialog();
            this.Show();
        }

        private void deleteBook_Click(object sender, EventArgs e)
        {
            deletebook delete = new deletebook();
            this.Hide();
            delete.ShowDialog();
            this.Show();
        }

        private void updateBook_Click(object sender, EventArgs e)
        {
            searchbook search = new searchbook();
            this.Hide();
            search.ShowDialog();
            this.Show();
        }

        private void allUsers_Click(object sender, EventArgs e)
        {
            string connect = Form1.userlogin;
            string getUsers = string.Format("select Uno, Uname, Usex, Uage, Upasswd from Users;");
            MySqlConnection conn = new MySqlConnection(connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(getUsers, connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            this.dataGridViewAllUsers.DataSource = dt;
        }

        private void AllBorrow_Click(object sender, EventArgs e)
        {
            string connect = Form1.userlogin;
            string getUsers = string.Format("select Uno, id, BorrowTime, BackTime from Ub;");
            MySqlConnection conn = new MySqlConnection(connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(getUsers, connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            this.dataGridViewAllUsers.DataSource = dt;
        }

        private void AllAdmins_Click(object sender, EventArgs e)
        {
            string connect = Form1.userlogin;
            string getUsers = string.Format("select Uno, Uname, Usex, Uage, Upasswd from Admins;");
            MySqlConnection conn = new MySqlConnection(connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(getUsers, connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            this.dataGridViewAllUsers.DataSource = dt;
        }
    }
}
