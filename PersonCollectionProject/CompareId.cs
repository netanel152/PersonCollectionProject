using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCollectionProject
{
    public class CompareId : IPersonComparable
    {
        public int ComparePerson(IPerson personA, IPerson personB)
        {
            return personA.GetId().CompareTo(personB.GetId());
        }
    }
}
