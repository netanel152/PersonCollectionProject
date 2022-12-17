using PersonCollectionProject.BL;
using PersonCollectionProject.Interfaces;
using PersonCollectionProject.Models;

IPerson personMoti = new Person("Moti", "Laufer", 1);
IPerson personFredi = new Person("Fredi", "Naim", 3);
IPerson personGow = new Person("Gow", "Landsman", 2);
IPerson personNetanel = new Person("Netanel", "Aknin", 0);
IPersonComparable NameCompare = new CompareFirstName(); //CompareFirstName Or CompareId();
PersonCollection PersonCollection = new(NameCompare);
PersonCollection.SubscribeToPersonCollection(new SubscriberClass().SubscriberMethod);

PersonCollection.Add(personMoti);
PersonCollection.Add(personFredi);
PersonCollection.Add(personGow);
PersonCollection.Add(personNetanel);

printCollection(PersonCollection);

PersonCollection.RemoveMax();
printCollection(PersonCollection);

PersonCollection.RemoveMax();
printCollection(PersonCollection);



static void printCollection(PersonCollection PersonCollection)
{
    Console.WriteLine("=====================\nThe current collection:");
    foreach (IPerson person in PersonCollection.GetPersonCollection())
    {
        Console.WriteLine(person.GetFirstName());
    }
    Console.WriteLine("=====================");
}