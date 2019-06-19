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
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void Reg_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textNameR.Text;
            string passwd = textPasswdR.Text;
            string dir;
            string t, sex;
            int age;
            string id = "", ada;
            String connectString = "server=localhost;User Id=root;password=password;Database=library;";
            if (radioButton5.Checked)
            {
                dir = "Users";
                ada = "";
            }
            else if (radioButton6.Checked)
            {
                dir = "Admins";
                ada = "A";
            }
            else
            {
                MessageBox.Show("请选择身份！");
                return;
            }
            if(textPasswdR.Text == "")
            {
                MessageBox.Show("您必须填写密码", "提示");
                labelMust.ForeColor = Color.Red;
                return;
            }
            if (radioButton3.Checked) sex = "G";
            else if (radioButton4.Checked) sex = "B";
            else
            {
                MessageBox.Show("请选择性别！");
                return;
            }
            t = textAge.Text;
            age = Convert.ToInt32(t);
            string checkname;
            string getid;
            using (MySqlConnection conn = new MySqlConnection(connectString))
            {

                conn.Open();
                int i;
                MySqlCommand cmd;
                for (i = 1; ; ++i)
                {
                    getid = "select Upasswd from " + dir + " where Uno = '" + ada + i.ToString() + "';";
                    
                    cmd = new MySqlCommand(getid, conn);
                    try
                    {
                        id = cmd.ExecuteScalar().ToString();
                    }
                    catch
                    {
                        id = ada + i.ToString();
                        break;
                    }
                }
                string find = "select Uname from " + dir + " where Uname = '" + name + "' and Upasswd = '" + passwd + "';";
                string grantu = "grant select on Book to '" + id + "'@'localhost';";
                string granta = "grant all privileges on Book to '" + id + "'@'localhost';" + "grant all privileges on ub to '" + id + "'@'localhost';" + "grant all privileges on Users to '" + id + "'@'localhost';" + "grant all privileges on Admins to '" + id + "'@'localhost';";
                string reg = "insert into " + dir + "(Uno, Uname, Usex, Uage, Upasswd) values('" + id + "','" + name + "','" + sex + "'," + age + ",'" + passwd + "');" + "create user '" + id + "'@'localhost' IDENTIFIED BY '" + passwd + "';";
                cmd = new MySqlCommand(reg, conn);
                cmd.ExecuteNonQuery();
                MySqlCommand grant;
                if(string.Equals(dir, "Users"))
                    grant = new MySqlCommand(grantu, conn);
                else grant = new MySqlCommand(granta, conn);
                grant.ExecuteNonQuery();
                MySqlCommand check = new MySqlCommand(find, conn);
                try
                {
                    checkname = check.ExecuteScalar().ToString();
                    MessageBox.Show("注册成功！\n用户ID:" + id + " 密码:" + passwd, "提示", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("注册失败！");
                }
                finally
                {
                    conn.Close();
                    this.Close();
                }
            }
        }
    }
}
