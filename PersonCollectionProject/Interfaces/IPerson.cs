
namespace PersonCollectionProject.Interfaces
{
    public interface IPerson
    {
        public int GetId();
        public string GetFirstName();
        public string GetLastName();
        public DateTime GetDateOfBirth();
        public int GetHeight();
    }
}
