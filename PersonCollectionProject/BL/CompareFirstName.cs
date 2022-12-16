using PersonCollectionProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCollectionProject.BL
{
    public class CompareFirstName : IPersonComparable
    {
        public int ComparePerson(IPerson personA, IPerson personB)
        {
            return personA.GetFirstName().CompareTo(personB.GetFirstName());
        }
    }
}
