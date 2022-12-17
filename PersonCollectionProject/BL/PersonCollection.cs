using PersonCollectionProject.Interfaces;

namespace PersonCollectionProject.BL
{
    public class PersonCollection
    {
        private readonly IPersonComparable _personComparable;
        private List<IPerson> _personCollection;
        private static readonly object lockObject = new();
        private event Action<IPerson, string> PersonsCollectionChanged;

        public PersonCollection(IPersonComparable personComparable)
        {
            _personComparable = personComparable;
            _personCollection = new List<IPerson>();
        }
        public List<IPerson> GetPersonCollection()
        {
            return _personCollection;
        }

        public void Add(IPerson newPerson)
        {
            lock (lockObject)
            {
                if (!_personCollection.Any())
                {
                    _personCollection.Add(newPerson);
                }
                else
                {
                    SortInsertPersonInCollection(newPerson);
                }
                PublishOnChangeCollection(newPerson, "added");
            }
        }

        private void PublishOnChangeCollection(IPerson person, string removeOrAdd)
        {
            if (PersonsCollectionChanged != null)
                PersonsCollectionChanged(person, removeOrAdd);
        }

        private void SortInsertPersonInCollection(IPerson newPerson)
        {
            foreach (IPerson personToCompare in _personCollection)
            {
                if (_personComparable.ComparePerson(newPerson, personToCompare) == 1)
                {
                    int index = _personCollection.IndexOf(personToCompare);
                    _personCollection.Insert(index, newPerson);
                    return;
                }
            }
            _personCollection.Add(newPerson);
        }

        public void RemoveMax()
        {
            IPerson? person = null;
            try
            {
                lock (lockObject)
                {
                    person = _personCollection[0];
                    _personCollection.RemoveAt(0);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            PublishOnChangeCollection(person, "removed");
        }

        public void SubscribeToPersonCollection(Action<IPerson, string> subscriber)
        {
            lock (lockObject)
            {
                PersonsCollectionChanged += subscriber;
            }
        }

        public void UnSubscribeToPersonCollection(Action<IPerson, string> subscriber)
        {
            lock (lockObject)
            {
                PersonsCollectionChanged -= subscriber;
            }
        }
    }
}
