using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db_Account_TranHaiPhong_API
{
    public class AccountController
    {
        Model_Account_Context mac = new Model_Account_Context();
        public IEnumerable<Account> Get()
        {
            using (Model_Account_Context mac = new Model_Account_Context())
            {
                return mac.Account.ToList();
            } 
        }
        public Account Get(int id)
        {
          try
            {
                return mac.Account.Where(a => a.AccId == id).First();
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public Account Post(Account acc)
        {
            using (Model_Account_Context mac = new Model_Account_Context())
            {
                mac.Account.Add(acc);
                mac.SaveChanges();
                return acc;
            }
        }
        public Account Put(int? id, Account acc)
        {
            Account accOld = mac.Account.Find(acc.AccId);
            int a = 0;
            a++;
            if(acc == null)return null;
            acc.Email = accOld.Email;
            acc.Name = accOld.Name;
            acc.AccNo = accOld.AccNo;
            mac.Entry(accOld).State = EntityState.Modified;
            mac.SaveChanges();
            return acc;
        }
    }
}
