using PersonCollectionProject.Interfaces;

namespace PersonCollectionProject.BL
{
    public class CompareId : IPersonComparable
    {
        public int ComparePerson(IPerson personA, IPerson personB)
        {
            return personA.GetId().CompareTo(personB.GetId());
        }
    }
}
