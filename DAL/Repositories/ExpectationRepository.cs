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
    public class ExpectationRepository : EFRepository<Exception>, IExpectationRepository
    {
        public ExpectationRepository(DbContext dbContext) : base(dbContext)
        {
        }


        public List<Expectation> All { get; }
        public List<Expectation> AllIncluding(params Expression<Func<Expectation, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Expectation GetById(params object[] id)
        {
            throw new NotImplementedException();
        }

        public void Add(Expectation entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Expectation entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expectation entity)
        {
            throw new NotImplementedException();
        }
    }
}
