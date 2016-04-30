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
    public class JobRepository : EFRepository<Job>, IJobRepository
    {
        public JobRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
