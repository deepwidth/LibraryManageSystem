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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string userlogin, userid, userpasswd, role;
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string passwd = textPasswd.Text;
            string dir;
            String connectString = "server=localhost;User Id=root;password=password;Database=library;";
            if (radioButton1.Checked) dir = "Users";
            else if (radioButton2.Checked) dir = "Admins";
            else
            {
                MessageBox.Show("请选择身份！");
                return;
            }
            string land = "select Uno from " + dir + " where Uno = '" + name + "' and Upasswd = '" + passwd + "';";
            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(land, conn);
                string checkname;
                try
                {
                    checkname = cmd.ExecuteScalar().ToString();
      //              MessageBox.Show("登陆成功！", "提示", MessageBoxButtons.OK);
                    userid = name;
                    userpasswd = passwd;
                    role = dir;
                    userlogin = "server=localhost;User Id=" + userid + ";password=" + userpasswd + ";Database = library;";
                    Form2 main = new Form2();
                    this.Hide();
                    main.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("账户或密码错误！");
                }
                finally
                {
                    conn.Close();
                    this.Close();
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reg register = new Reg();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }
    }
}
