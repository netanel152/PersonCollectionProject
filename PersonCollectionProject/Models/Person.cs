using PersonCollectionProject.Interfaces;

namespace PersonCollectionProject.Models
{
    public class Person : IPerson
    {
        public DateTime DateOfBirth { get; }
        public string FirstName { get; }
        public int Height { get; }
        public int Id { get; }
        public string LastName { get; }

        public Person(string FirstName, string lastName, int id)
        {
            this.FirstName = FirstName;
            LastName = lastName;
            this.Id = id;
        }

        public int GetId()
        {
            return Id;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public DateTime GetDateOfBirth()
        {
            return DateOfBirth;
        }

        public int GetHeight()
        {
            return Height;
        }
    }
}
