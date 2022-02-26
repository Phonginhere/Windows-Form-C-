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
using WebApplication_Linq_Product.Models;

namespace WebApplication_Linq_Product.Controllers
{
    public class ProBuysController : ApiController
    {
        private Model_Product db = new Model_Product();

        // GET: api/ProBuys
        public IQueryable<ProBuy> GetProBuys()
        {
            return db.ProBuys;
        }

        // GET: api/ProBuys/5
        [ResponseType(typeof(ProBuy))]
        public IHttpActionResult GetProBuy(int id)
        {
            ProBuy proBuy = db.ProBuys.Find(id);
            if (proBuy == null)
            {
                return NotFound();
            }

            return Ok(proBuy);
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