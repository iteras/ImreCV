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
    public class PersonAttributeRepository : EFRepository<PersonAttribute>, IPersonAttributeRepository

    {
        public PersonAttributeRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
