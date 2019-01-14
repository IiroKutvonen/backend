using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExample.Models;


namespace WebApiExample.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PersondbContext _context;

        public PersonRepository(PersondbContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> Read()
        {
            // SELECT * FROM PERSON;
            return _context.person
                //.Include(p=>p.phone)
                .ToList();
        }

        public Person Read(int id)
        {
            // SELECT * FROM PERSON WHERE ID={id};
            return _context.person
                .Include(p=>p.phone)
                .FirstOrDefault(p => p.Id == id);
        }

        public Person Update(int id, Person person)
        {
            throw new NotImplementedException();
        }
    }
}
