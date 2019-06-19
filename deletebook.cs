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
    public partial class deletebook : Form
    {
        public deletebook()
        {
            InitializeComponent();
        }

        private void button1_search(object sender, EventArgs e)
        {
            string connect = Form1.userlogin;
            MySqlConnection conn;
            string ID = textBoxID.Text;
            string Bookname;
            string search = "select Bookname from book where id = '" + ID + "';";
            string delete = "delete from book where id = '" + ID + "';";
                //未完待续
            using (conn = new MySqlConnection(connect))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(search, conn);
                try
                {
                    Bookname = cmd.ExecuteScalar().ToString();
                    DialogResult result = MessageBox.Show("已找到图书：《" + Bookname +"》\n是否删除此图书？", "提示",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        cmd = new MySqlCommand(delete, conn);
                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("删除成功", "提示");
                            return;
                        }
                        catch
                        {
                            MessageBox.Show("删除失败", "错误");
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("未找到图书信息！", "错误");
                    return;
                }
                finally
                {

                }
            }
        }
    }
}
