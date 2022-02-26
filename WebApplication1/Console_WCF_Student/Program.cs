using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_WCF_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client mm = new ServiceReference1.Service1Client();
            try
            {
                ServiceReference1.Student st = new ServiceReference1.Student();

                Console.WriteLine("Input Name: "); st.StudentName = Console.ReadLine();
                Back:
                try
                {
                    Console.WriteLine("Input Birth Of Date: "); st.BirthOfDate = Convert.ToDateTime(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wrong Date - The date is MM/DD/YYYY");
                    goto Back;
                }
                
                Console.WriteLine("Input Address: "); st.Address = Console.ReadLine();
                Console.WriteLine("Input img: "); st.Picture = Console.ReadLine();

                //st.StudentName = "Phong";
                //st.BirthOfDate = Convert.ToDateTime("08/24/2020");
                //st.Address = "CC, Ha Noi";
                //st.Picture = "phonggggg.jpg";

                mm.addStudent(st);
                Console.WriteLine("Success");
                Console.WriteLine("=============================");
            }
            catch
            {
                Console.WriteLine("fail");
            }
           

            var list = mm.getStudents();
            foreach(var s in list)
            {
                Console.WriteLine("ID: " + s.StudentId + " Name: " + s.BirthOfDate + " Cmt: " + s.Address + " Picture: " + s.Picture);
            }
            Console.ReadLine();
        }
    }
}
