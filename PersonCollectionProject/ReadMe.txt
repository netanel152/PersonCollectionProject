

I made an example in the main function (Program.cs).

The Class Person implements the IPerson (the interface you gave me) for creating persons.

I created the IPersonComparable which has the comparison signature of the unknown algorithm.

For creating my PersonCollection you have to send the constructor the IPersonComparable algorithm (injection).

I made 2 examples Classes for the algorithm CompareId, CompareFirstName which implements the IPersonComparable.

In the collection class I made subscribe and unsucbscribe methods for the listeners (subscribers).

I did also SubscriberClass to demonstrate the publish functionality.

Thank you and have a good week,

Netanel Aknin.