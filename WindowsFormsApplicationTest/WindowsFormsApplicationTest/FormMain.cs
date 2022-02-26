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
    public partial class FormMain : Form
    {
        String sql_con = @"Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=Classes;User ID=sa;Password=1234567;";
        SqlConnection con;
        SqlCommand exec;
        SqlDataReader read;
        SqlDataAdapter ada;

        public static string id = null;
        

        public FormMain()
        {
            InitializeComponent();
            con = new SqlConnection(sql_con);
            labelTL.Visible = false;
            cbTenLop.Visible = false;
            btnSave.Enabled = false;
           
        }
        public void show()
        {
            DataSet1TableAdapters.tblStudentTableAdapter student = new DataSet1TableAdapters.tblStudentTableAdapter();
            dataGridView1.DataSource = student.GetDataBy();
            tblTenSV.DataBindings.Clear();
            tblTenSV.DataBindings.Add("text", dataGridView1.DataSource, "TenSV");

            tblUserNm.DataBindings.Clear();
            tblUserNm.DataBindings.Add("text", dataGridView1.DataSource, "UserNm");

            tblDc.DataBindings.Clear();
            tblDc.DataBindings.Add("text", dataGridView1.DataSource, "DiaChi");

            cbTenLop.DataBindings.Clear();
            cbTenLop.DataBindings.Add("text", dataGridView1.DataSource, "TenLop");

            //SqlDataAdapter sda = new SqlDataAdapter(sql_con, con);
            //DataTable dt = new DataTable();
            //student.Fill(dt);
            //if(student != null)
            //{
            //    foreach(DataRow dr in student.)
            //    {
            //        id = dr["MaSv"].ToString();
            //    }
            //}


        }
        public void show_ComboBox()
        {
            String sql = "SELECT * from tblClasses ";
            SqlCommand sc = new SqlCommand(sql, con);
            sc.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cbTenLop.DataSource = dt;
            cbTenLop.DisplayMember = "TenLop";
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String lop = cbTenLop.Text;
            String tensv = tblTenSV.Text;
            String usern = tblUserNm.Text;
            String diachi = tblDc.Text;
            String update = "UPDATE tblStudent SET TenSV = '" + tensv + "', UserNm = '"+ usern + "',DiaChi = '" + diachi + "', MaLop = '"+cbTenLop.SelectedValue+ "' where MaSv = '"+id+"' ";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String tensv = tblTenSV.Text;

            
            String sql = "DELETE from tblStudent where TenSV = @TenSV";
            exec = new SqlCommand(sql, con);
            con.Open();
            exec.Parameters.AddWithValue("@TenSV", tensv);
            exec.ExecuteNonQuery();
            con.Close();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int row = e.RowIndex;
            //DataGridViewRow rw = 
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            labelTL.Visible = true;
            cbTenLop.Visible = true;
            btnSave.Enabled = true;
            show_ComboBox();
            String sql_ma_lop = "Select MaLop from tblClasses where TenLop = @TenLop";
            exec = new SqlCommand(sql_ma_lop, con);
            String i = null;

            con.Open();

            exec.Parameters.AddWithValue("@TenLop", cbTenLop.Text);
            exec.ExecuteNonQuery();
            
            con.Close();
            //DataAd
            //if (student != null)
            //{
            //    foreach (DataRow dr in student.)
            //    {
            //        id = dr["MaSv"].ToString();
            //    }
            //}

            //String sql = "Insert into tblStudent values ('"++"')";
        }
    }
}
