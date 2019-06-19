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
    public partial class dataTest : Form
    {
        public dataTest()
        {
            InitializeComponent();
        }

        private void dataTest_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectString = "server=localhost;User Id=root;password=password;Database=library;";
            string sql = string.Format("select Id, bookName, author, score, press, price, amount from book where bookName like '%" + SearchBookNameTextBox.Text.Trim() + "%'");
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connectString);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            this.SearchBookDataGridView.DataSource = dt;
        }
    }
}
