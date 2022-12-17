using PersonCollectionProject.BL;
using PersonCollectionProject.Interfaces;
using PersonCollectionProject.Models;

IPerson personMoti = new Person("Moti", "Laufer", 203698774);
IPerson personFredi = new Person("Fredi", "Naim", 147741478);
IPerson personRubi = new Person("Rubi", "Landsman", 258963147);
IPerson personNetanel = new Person("Netanel", "Aknin", 789456123);
IPersonComparable NameCompare = new CompareFirstName(); //Choose which type of compering you want for expample => CompareFirstName Or CompareId;
PersonCollection PersonCollection = new(NameCompare);
PersonCollection.SubscribeToPersonCollection(new SubscriberClass().SubscriberMethod);

PersonCollection.Add(personMoti);
PersonCollection.Add(personFredi);
PersonCollection.Add(personRubi);
PersonCollection.Add(personNetanel);

printCollection(PersonCollection);

PersonCollection.RemoveMaxValue();
printCollection(PersonCollection);

PersonCollection.RemoveMaxValue();
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