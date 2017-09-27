using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mchaltue.Models;

namespace mchaltue.Controllers
{
    [Route("api/[controller]")]
    public class MagazinesController : Controller
    {
        public LibraryContext _db { get; private set; }

        // List<Magazine> Magazines = new List<Magazine>() {
        //     new Magazine("THYME", "thum productions", 80, "Oh No, The World Is Screwed Again", 1300),
        //     new Magazine("The Cram Food Mag", "CFM Productions", 900, "EAT!", 93)
        // };

        // GET api/values

        public MagazinesController(LibraryContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IEnumerable<Magazine> Get()
        {
            return _db.Magazines;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Magazine Get(int id)
        {
            return _db.Magazines.Find(id);
        }

        // [HttpGet("{mag}")]
        // public IEnumerable<Magazine> Get(string mag)
        // {
        //     return _db.Magazines.Where(m => m.Title.Contains(mag)).ToList();
        // }

        // public string Get(int x, bool b)
        // {
        //     return "cool";
        // }

        // POST api/values
        [HttpPost]
        public IEnumerable<Magazine> Post([FromBody]Magazine value)
        {
            _db.Magazines.Add(value);
            _db.SaveChanges();
            return _db.Magazines;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
