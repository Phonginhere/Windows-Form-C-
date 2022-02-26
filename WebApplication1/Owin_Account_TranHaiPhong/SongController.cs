using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Owin_Account_TranHaiPhong
{
    public class SongController : ApiController
    {
        private List<Song> list = new List<Song>();
        //List<Song> song = new List<Song>();

        public SongController()
        {
            this.list.Add(new Song() { Title = "Hey Jude", Artist = "The Beatles", Price = 1.9 });
            this.list.Add(new Song() { Title = "I Gotta Feeling", Artist = "The Black Eyed Peas", Price = 1.5 });
            this.list.Add(new Song() { Title = "The Twist", Artist = "Chubby Checker", Price = 2 });
        }

        //public List<Song> getList()
        //{
           
        //    return list;
        //}

        public IHttpActionResult Get()
        {
            return Ok(list);
        }

        public Song Get(int id)
        {
            var m1 = list;
            var e = from p in list where p.Price == id select p;
            return e.First();
        }

        public void Post(Song item)
        {

        }
        public void Put(int id, Song item)
        {

        }
        public void Delete(int id)
        {

        }
    }
}
