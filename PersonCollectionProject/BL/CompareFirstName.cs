using PersonCollectionProject.Interfaces;

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
