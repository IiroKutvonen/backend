using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiExample.Models;
using WebApiExample.Repositories;

namespace WebApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonsController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }


        // GET api/values
        [HttpGet]
        public ActionResult<List<Person>> GetPersons()
        {
            //var users = new List<Person>
            //{
            //    new Person("James", 45),
            //    new Person ("Lisa", 65),
            //};
            return new JsonResult(_personRepository.Read());
        }

        // GET api/persons/5
        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            var person = _personRepository.Read(id);
            return new JsonResult(person);
        }
    }
}