using Interview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepositoryImplementation
{
    public class Employee : IStoreable
    {
        public IComparable Id { get; set;  }
    }
}
