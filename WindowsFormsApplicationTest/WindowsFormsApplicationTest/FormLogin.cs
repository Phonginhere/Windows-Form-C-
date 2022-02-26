using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationTest
{
    public partial class FormLogin : Form
    {
        String sql_con = @"Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=Classes;User ID=sa;Password=1234567;";
        SqlConnection con;
        SqlCommand exec;
        SqlDataReader read;
        SqlDataAdapter ada;
        public FormLogin()
        {
            InitializeComponent();
            con = new SqlConnection(sql_con);
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String user_name = tblUsern.Text;
            String pass = tblPassword.Text;
            try
            {
                con.Open();
                String sql = "Select * from tblStudent where UserNm = '" + user_name + "' and Password = '" + pass + "'";
                exec = new SqlCommand(sql, con);
                read = exec.ExecuteReader();

                if (read.Read())
                {
                    MessageBox.Show("Thành Công!!!");
                    FormMain fm = new FormMain();
                    fm.Show();
                    this.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Tài Khoản hoặc mật khẩu không trùng nhau!!!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi sql");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
