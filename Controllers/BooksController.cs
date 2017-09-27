using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mchaltue.Models;

namespace mchaltue.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        public LibraryContext _db { get; private set; }

        // List<Book> Books = new List<Book>() {
        //     new Book("A Boy and His Dog", "Penguin", 1080, "fjciudfj8"),
        //     new Book("The Star Wars", "Lucasfilm", 89, "904rufeh"),
        //     new Book("The Star Trek", "Mucusfilm", 399, "di9weuf4j")
        // };

        public BooksController(LibraryContext db)
        {
            _db = db;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _db.Books;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return _db.Books.Find(id);
        }

        // [HttpGet("{banana}")]
        // public IEnumerable<Book> Get(string banana)
        // {
        //     return _db.Books.Where(m => m.Title.Contains(banana)).ToList();
        // }

        // public string Get(int x, bool b)
        // {
        //     return "cool";
        // }

        // POST api/values
        [HttpPost]
        public IEnumerable<Book> Post([FromBody]Book value)
        {
            _db.Books.Add(value);
            _db.SaveChanges();
            return _db.Books;
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
