using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
