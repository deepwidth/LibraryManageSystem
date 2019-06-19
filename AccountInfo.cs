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
    public partial class AccountInfo : Form
    {
        public AccountInfo()
        {
            InitializeComponent();
        }

        private void AccountInfo_Load(object sender, EventArgs e)
        {
            String connectString = "server=localhost;User Id=root;password=password;Database=library;";
            string getname = "select Uname from " + Form1.role + " where Uno = '" + Form1.userid + "';";
            string getsex = "select Usex from " + Form1.role + " where Uno = '" + Form1.userid + "';";
            string getage = "select Uage from " + Form1.role + " where Uno = '" + Form1.userid + "';";
            string temp;
            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                conn.Open();
                labelID.Text = Form1.userid;
                MySqlCommand cmd = new MySqlCommand(getname, conn);
                try
                {
                    temp = cmd.ExecuteScalar().ToString();
                    textName.Text = temp;
                }
                catch
                {
                    textName.Text = "GET Name ERROR!!!";
                }

                cmd = new MySqlCommand(getsex, conn);
                try
                {
                    temp = cmd.ExecuteScalar().ToString();
                    if (string.Equals(temp, "B")) radioButton4.Checked = true;
                    else if (string.Equals(temp, "G")) radioButton3.Checked = true;
                }
                catch
                {

                }

                cmd = new MySqlCommand(getage, conn);
                try
                {
                    temp = cmd.ExecuteScalar().ToString();
                    textAge.Text = temp;
                }
                catch
                {

                }

                textPasswd.Text = Form1.userpasswd;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string role = Form1.role;
            string sex;
            String connectString = "server=localhost;User Id=root;password=password;Database=library;";
            if (radioButton3.Checked) sex = "G";
            else if (radioButton4.Checked) sex = "B";
            else
            {
                MessageBox.Show("请选择性别");
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                conn.Open();
                string update = "update " + role + " set Uname = '" + textName.Text + "', Usex = '" + sex + "', Uage = '" + textAge.Text + "', Upasswd = '" + textPasswd.Text + "' where Uno = '" + labelID.Text + "';";
                MySqlCommand cmd = new MySqlCommand(update, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改成功");
                    Form1.userpasswd = textPasswd.Text;
                    this.Close();
                }
                catch
                {
                }
            }
        }
    }
}
