using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCollectionProject.Interfaces
{
    public interface IPersonComparable
    {
        int ComparePerson(IPerson personA, IPerson personB);
    }
}
