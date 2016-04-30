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
    public class LanguageRepository : EFRepository<Language>, ILanguageRepository
    {
        public LanguageRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
