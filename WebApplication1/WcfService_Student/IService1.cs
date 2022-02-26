using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService_Student
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        List<Student> getStudents();

        [OperationContract]
        void addStudent(Student s);

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
        public int StudentId { get; set; }

        [DataMember]
        public String StudentName { get; set; }

        [DataMember]
        public DateTime BirthOfDate { get; set; }

        [DataMember]
        public String Address { get; set; }

        [DataMember]
        public String Picture { get; set; }


}
    

    public class TestSinhVien
    {
        static string sql_con = @"Data Source=DESKTOP-FERTOLL\PHONGTRAN;Initial Catalog=ListStudents;User ID=sa;Password=1234567";
        static SqlConnection con = new SqlConnection(sql_con);
        static String sql_cmd = "Select * from Students";
       

        public static List<Student> getListStudents()
        {
            List<Student> list = new List<Student>();
            //list.Add(new Student() { StudentId = 1, StudentName = "Phong", StudentCmt = "Haha" });
            //list.Add(new Student() { StudentId = 2, StudentName = "Phog", StudentCmt = "Ha" });
            //list.Add(new Student() { StudentId = 3, StudentName = "Phg", StudentCmt = "Hi" });
            //return list;

            SqlCommand cmd = new SqlCommand(sql_cmd, con);

            con.Open();

            SqlDataReader read = cmd.ExecuteReader();
            
            while (read.Read())
            {
                    Student std = new Student();
                    std.StudentId = (int)read["StudentId"];
                    std.StudentName = read["StudentName"].ToString();
                    std.BirthOfDate = (DateTime)read["BirthOfDate"];
                    std.Address = read["Address"].ToString();
                    std.Picture = read["Picture"].ToString();
                    list.Add(std);
            }
            con.Close();
            return list;
        }
    }
}
