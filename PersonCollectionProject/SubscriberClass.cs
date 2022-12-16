using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCollectionProject
{
    public class SubscriberClass : ISubscriber
    {
        public void SubscriberMethod(IPerson obj,string changedMethod)
        {
 
            Console.WriteLine(obj.GetFirstName() + $" was {changedMethod}!!");
        }
    }
}
