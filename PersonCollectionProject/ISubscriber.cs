using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCollectionProject
{
    public interface ISubscriber
    {
        void SubscriberMethod(IPerson person,string changedMethod);
    }
}
