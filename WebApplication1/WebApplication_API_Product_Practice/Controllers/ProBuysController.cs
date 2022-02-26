using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication_API_Product_Practice.Models;

namespace WebApplication_API_Product_Practice.Controllers
{
    public class ProBuysController : ApiController
    {
        private Model_Product db = new Model_Product();

        // GET: api/ProBuys
        public IQueryable<ProBuy> GetProBuys()
        {
            return db.ProBuys;
        }

        // GET: api/ProBuys/5 //List all

        //[ResponseType(typeof(ProBuy))]
        //public IHttpActionResult GetProBuy(int id)
        //{
        //    ProBuy proBuy = db.ProBuys.Find(id);
        //    if (proBuy == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(proBuy);
        //}

        // GET: api/ProBuys/5 //Question 1

        //[ResponseType(typeof(ProBuy))]
        //public int? GetProBuy(int id)
        //{

        //    //var Total = from p in db.ProBuys
        //    //            where p.ProId == id
        //    //            select p.ProNumber;
        //    ProBuy p = db.ProBuys.Find(id);
        //    return p.ProNumber;
        //}

        // GET: api/ProBuys/5 //Question 2

        //[ResponseType(typeof(ProBuy))]
        //public double GetProBuy(int id)
        //{
        //    var Total_Money = db.ProBuys.Sum(p => p.ProBuyPrice) * db.ProBuys.Sum(p=>p.ProNumber);

        //    return Convert.ToDouble(Total_Money);
        //}

        // GET: api/ProBuys/5 //Question 3
        [ResponseType(typeof(ProBuy))]
        public double GetProBuy(int id)
        {
            //var Total_Money = db.ProBuys.GroupBy(p=>p.ProId).Sum(p => p.ProBuyPrice) * db.ProBuys.Sum(p => p.ProNumber);
            //var Total_Money = (from t in db.ProBuys group t by t.ProId).Sum();
            //var Total_Money = from t in db.ProBuys group t by t.ProId;
            //var sum = db.ProBuys.ToList().GroupBy(c=>c.ProId).Select(c => c.Select(d=>d.ProNumber));
            //var sum1 = db.ProBuys.ToList().GroupBy(c => c.ProId).Select(c => c.Select(d => d.ProBuyPrice));
            //var sum2 = sum * sum1;

            //var summaryApproach1 = db.ProBuys.GroupBy(t => t.ProId)
            //               .Select(t => new
            //               {
            //                   Category = t.Key,
            //                   Count = t.Count(),
            //                   Amount = t.Sum(ta=> ta.ProNumber),
            //               }).ToList();

           var Total_Money = from p in db.ProBuys group p by p.ProId into g
            select new
            {
                SumTotal = g.Sum(x => x.ProBuyPrice),
                SumDone = g.Sum(x => x.ProNumber)
            };


            return Convert.ToDouble(Total_Money);
        }

        // PUT: api/ProBuys/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProBuy(int id, ProBuy proBuy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != proBuy.ProBuyId)
            {
                return BadRequest();
            }

            db.Entry(proBuy).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProBuyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ProBuys
        [ResponseType(typeof(ProBuy))]
        public IHttpActionResult PostProBuy(ProBuy proBuy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProBuys.Add(proBuy);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = proBuy.ProBuyId }, proBuy);
        }

        // DELETE: api/ProBuys/5
        [ResponseType(typeof(ProBuy))]
        public IHttpActionResult DeleteProBuy(int id)
        {
            ProBuy proBuy = db.ProBuys.Find(id);
            if (proBuy == null)
            {
                return NotFound();
            }

            db.ProBuys.Remove(proBuy);
            db.SaveChanges();

            return Ok(proBuy);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProBuyExists(int id)
        {
            return db.ProBuys.Count(e => e.ProBuyId == id) > 0;
        }
    }
}