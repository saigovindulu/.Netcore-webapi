using System.Collections.Generic;
using System.Linq;
using PersonApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CorePersonApi.Controllers
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        List<person> people = People.GetPeople();

        // GET api/<controller>
        [HttpGet]
        public IEnumerable<person> Get()
        {
            return people;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public person Get(int id)
        {
            return People.GetPeople().FirstOrDefault(p => p.Id == id);
        }
    }
}