using PersonCollectionProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCollectionProject.BL
{
    public class SubscriberClass : ISubscriber
    {
        public void SubscriberMethod(IPerson obj, string action)
        {
            Console.WriteLine(obj.GetFirstName() + $" was {action}!!");
        }
    }
}
