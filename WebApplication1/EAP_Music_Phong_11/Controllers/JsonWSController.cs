using EAP_Music_Phong_11.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace EAP_Music_Phong_11.Controllers
{
    public class JsonWSController : ApiController
    {
        private DataContext db = new DataContext();

        public JToken Get()
        {
            return JObject.Parse(db.Albums.ToString());
        }

        public JToken Get(int id)
        {
            return JObject.Parse(db.Albums.FirstOrDefault(e=>e.GenreId == id).ToString());
        }
    }
}