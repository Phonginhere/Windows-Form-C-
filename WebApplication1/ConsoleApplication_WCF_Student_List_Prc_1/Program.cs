using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_WCF_Student_List_Prc_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client mm = new ServiceReference1.Service1Client();

            var list = mm.getListStudent();

            foreach(var st in list)
            {
                Console.WriteLine("id: " + st.id + " name: " + st.name + " email: " + st.email);
            }
            Console.ReadLine();
        }
    }
}
