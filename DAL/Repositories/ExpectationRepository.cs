using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Domain;

namespace DAL.Repositories
{
    public class ExpectationRepository : EFRepository<Expectation>, IExpectationRepository
    {
        public ExpectationRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
