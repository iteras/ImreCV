using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Domain;

namespace DAL
{
    
    public class DataBaseContext : DbContext//, IDbContext
    {
        //private readonly NLog.ILogger _logger;
        //private readonly string _instanceId = Guid.NewGuid().ToString();

        public DataBaseContext() : base("DbConnectionString")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<KustersDbContext,MigrationConfiguration>());
            Database.SetInitializer(new DropCreateDatabaseAlways<DataBaseContext>());
#if DEBUG
            Database.Log = s => Trace.Write(s);
#endif
        }

        // DataBaseContext.SetInitialize

        // public DbSet<Person> Persons { get; set; }
        public DbSet<ComputerSkill> ComputerSkills { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Expectation> Expectations { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<PersonAttribute> PersonAttributes { get; set; }


        //public IDbSet<Person> Persons { get; set; }
        //public IDbSet<ComputerSkill> ComputerSkills { get; set; }
        //public IDbSet<Education> Educations { get; set; }
        //public IDbSet<Expectation> Expectations { get; set; }
        //public IDbSet<Job> Jobs { get; set; }
        //public IDbSet<Language> Languages { get; set; }
        //public IDbSet<PersonAttribute> PersonAttributes { get; set; }

        //public System.Data.Entity.DbSet<Domain.Person> Persons { get; set; }

        public System.Data.Entity.DbSet<Domain.Person> Persons { get; set; }
    }
}
