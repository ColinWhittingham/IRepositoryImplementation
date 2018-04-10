using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepositoryImplementation
{
    public class FullName : IComparable<FullName>
    {
        public string Value { get; set; }

        public int CompareTo(FullName other)
        {
            return Value.CompareTo(other.Value);
        }
    }
}
