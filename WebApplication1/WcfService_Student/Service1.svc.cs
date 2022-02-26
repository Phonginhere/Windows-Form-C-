using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService_Student
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        static string sql_con = @"Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=ListStudents;User ID=sa;Password=1234567";
        static SqlConnection con = new SqlConnection(sql_con);
        static String sql_insert = "Insert into Students values(@StudentName, @BirthOfDate, @Address, @Picture)";

        public void addStudent(Student s)
        {
            SqlCommand cmd = new SqlCommand(sql_insert, con);
            con.Open();
          

            //cmd.Parameters.AddWithValue("@StudentName", "Phong");
            //cmd.Parameters.AddWithValue("@BirthOfDate", "03/05/2021");
            //cmd.Parameters.AddWithValue("@Address", "Cầu Giấy, HN");
            //cmd.Parameters.AddWithValue("@Picture", "phong.jpg");

            cmd.Parameters.AddWithValue("@StudentName", s.StudentName);
            cmd.Parameters.AddWithValue("@BirthOfDate", s.BirthOfDate);
            cmd.Parameters.AddWithValue("@Address", s.Address);
            cmd.Parameters.AddWithValue("@Picture", s.Picture);

            int read = cmd.ExecuteNonQuery();
            if (read > 0)
            {
                Console.WriteLine("Thành công");
            }
            else
            {
                Console.WriteLine("Thất bại");
            }
            con.Close();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<Student> getStudents()
        {
            List<Student> list = new List<Student>();
            list = TestSinhVien.getListStudents();
            return list;
        }

        
    }
}
