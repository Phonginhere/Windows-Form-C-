using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace ConsoleApplication_API_DBFirst_Account
{
    public class AccountController : ApiController
    {
        Model_Acc da = new Model_Acc();
        public IEnumerable<Account> Get()
        {
            using (Model_Acc da = new Model_Acc())
            {
                return da.Accounts.ToList();
            }
        }
        public Account Get(int id)
        {
            try
            {
                return da.Accounts.Where(a => a.AccId == id).First();
                //var myAcc = from m in da.Accounts where m.AccId == id select m; //linq
                //return myAcc.First();
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public Account Post(Account acc)
        {
            using (Model_Acc da = new Model_Acc())
            {
                da.Accounts.Add(acc);
                da.SaveChanges();
                return acc;
            }
        }
        //public Account Put(int? id, Account acc)
        //{
        //    Account accOld = da.Accounts.Find(acc.AccId);
        //    int a = 0;
        //    a++;
        //    if (acc == null) return null;
        //    acc.AccEmail = accOld.AccEmail;
        //    acc.AccName = accOld.AccName;
        //    acc.AccNo = accOld.AccNo;
        //    da.Entry(accOld).State = EntityState.Modified;
        //    da.SaveChanges();
        //    return acc;
        //}

        public void Put(Account acc)
        {

            Account s = da.Accounts.Find(acc.AccId);

            s.AccId = acc.AccId;
            s.AccName = acc.AccName;
            s.AccEmail = acc.AccEmail;
            s.AccNo = acc.AccNo;

            da.SaveChanges();
        }
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid student id");

            using (var ctx = new Model_Acc())
            {
                var account = ctx.Accounts.Where(s => s.AccId == id).FirstOrDefault();

                ctx.Entry(account).State = EntityState.Deleted;
                ctx.SaveChanges();
            }

            return Ok();
        }
    }

}
