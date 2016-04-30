using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUOW
    {
        void Commit();
        void RefreshAllEntities();

        T GetRepository<T>() where T : class;

        IComputerSkillRepository ComputerSkills { get; }
        IEducationRepository Educations { get; }
        IExpectationRepository Expectations { get; }
        IJobRepository Jobs { get; }
        ILanguageRepository Languages { get; }
        IPersonAttributeRepository PersonAttributes { get; }
        IPersonRepository Persons { get; }
    }
}
