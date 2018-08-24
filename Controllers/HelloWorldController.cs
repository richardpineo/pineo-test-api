using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using PineoTest.Models;

namespace HelloWorldApi.Controllers
{
    [Route("api/hw")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        private readonly HelloWorldContext _context;

        public HelloWorldController(HelloWorldContext context)
        {
            _context = context;

            if (_context.HelloWorldItems.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.HelloWorldItems.Add(new HelloWorldItem());
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<HelloWorldItem>> GetAll()
        {
            return _context.HelloWorldItems.ToList();
        }

        [HttpGet("{id}", Name = "GetHelloWorld")]
        public ActionResult<HelloWorldItem> GetById(long id)
        {
            var item = _context.HelloWorldItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
    }
}