using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Domain;

namespace DAL.Repositories
{
    public class PersonRepository : EFRepository<Person>, IPersonRepository
    {
        public PersonRepository(DbContext dbContext) : base(dbContext)
        {
        }
        public List<Person> GetAllPersons()
        {
            return DbSet.Where(p => p.PersonId != -1 ).OrderBy(o => o.Lastname).ThenBy(o => o.Firstname).Take(100).ToList();
        }

        //public Person GetForUser(int personId, int personId)
        //{
        //    return DbSet.FirstOrDefault(a => a.PersonId == personId && a.PersonId == personId);
        //}
    }
}
