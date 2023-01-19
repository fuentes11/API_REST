using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiRest.Controllers
{
    public class ArticleController : ApiController
    {
        private WorldEntities1 Context = new WorldEntities1();
        // Method GET /api/article
        [HttpGet]
        public IEnumerable<city> Get()
        {
            using (WorldEntities1 db = new WorldEntities1())
            {
                db.Configuration.ProxyCreationEnabled = false;
                return db.city.ToList();
            }
        }
        // Method Get by ID /api/article/{id}
        [HttpGet]
        public city Get(int id)
        {
            using (WorldEntities1 db = new WorldEntities1())
            {
                db.Configuration.ProxyCreationEnabled = true;
                return db.city.FirstOrDefault(x => x.id == id); 
            }
        }
        //Method Post api/Article
        [HttpPost]
        public IHttpActionResult AddCity([FromBody]city City)
        {
            if (ModelState.IsValid)
            {
                Context.city.Add(City);
                Context.SaveChanges();
                return Ok(City);
            }
            else
            {
                return BadRequest();
            }
        }
        //Method Update api/Article/{id}
        [HttpPut]
        public IHttpActionResult UpdateCity(int id, [FromBody]city City)
        {
            if(ModelState.IsValid)
            {
                var CityExist = Context.city.Count(e => e.id== id)>0;
                if (CityExist)
                {
                    Context.Entry(City).State = System.Data.Entity.EntityState.Modified;
                    Context.SaveChanges(); 
                    return Ok(City);
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return BadRequest();
            }
        }
        //Method Delete api/Article/{id}
        [HttpDelete]
        public IHttpActionResult DeleteCity(int id) 
        {
            var City = Context.city.Find(id);
            if(City != null)
            {
                Context.city.Remove(City);
                Context.SaveChanges(); 
                return Ok(City);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
