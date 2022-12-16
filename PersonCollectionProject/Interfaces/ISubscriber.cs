using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCollectionProject.Interfaces
{
    public interface ISubscriber
    {
        void SubscriberMethod(IPerson person, string changedMethod);
    }
}
