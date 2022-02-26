using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OWIN_Song_TranHaiPhong
{
    public class AccountController :ApiController
    {
        static private List<Account> list = new List<Account>();
        //List<Song> song = new List<Song>();

         public AccountController()
        {
             
            list.Add(new Account() { Name = "Steve Job", Email = "steve@gmail.com", AccNo = 12345678 });
            list.Add(new Account() { Name = "Bill Gates", Email = "bill@microsoft.com", AccNo = 87654321 });
            list.Add(new Account() { Name = "Steve Job", Email = "larry@oracle.com", AccNo = 11223344 });
        }

        public IHttpActionResult Get()
        {
            return Ok(list); //trả về toàn bộ
        }

        public Account Get(int id)
        {
            //var m1 = list;
            //var e = from p in list where p.AccNo == id select p;
            //return e.First();
            return list.First(s => s.AccNo == id); //lây thông tin của tài khoản riêng thì trả đúng dữ liệu riêng
        }

        public void Post(Account item)
        {
            int a = 0;
            a = list.Count();
            list.Add(item);
            a = list.Count();
            int b = list.Count();
            int x = 0; 
            x++; 
        }
        public void Put(int id, Account item)
        {

        }
        public void Delete(int id)
        {

        }
    }
}
