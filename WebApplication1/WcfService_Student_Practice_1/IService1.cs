using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService_Student_Practice_1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        List<Student> getListStudent();

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class Student
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public String name { get; set; }
        [DataMember]
        public String email { get; set; }

    }

    public class TestStudent
    {
        static String sql_con = @"Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=Db_SinhVien;User ID=sa;Password=1234567";
        static String sql_dis = "Select * from SinhVien";
        static SqlConnection con = new SqlConnection(sql_con);

        public static List<Student> getListStudent()
        {
            SqlCommand cmd = new SqlCommand(sql_dis, con);
            List<Student> student_list = new List<Student>();

            con.Open();

            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                Student std = new Student();
                std.id = (int)read["id"];
                std.name = read["name"].ToString();
                std.email = read["email"].ToString();
                student_list.Add(std);
            }
            con.Close();
            return student_list;
        }
        
    }
}
