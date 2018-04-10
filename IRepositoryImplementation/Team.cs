using Interview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepositoryImplementation
{
    public class Team : IRepository<Employee>
    {
        public IEnumerable<Employee> All()
        {
            throw new NotImplementedException();
        }

        public void Delete(IComparable id)
        {
            throw new NotImplementedException();
        }

        public Employee FindById(IComparable id)
        {
            throw new NotImplementedException();
        }

        public void Save(Employee item)
        {
            throw new NotImplementedException();
        }
    }
}
