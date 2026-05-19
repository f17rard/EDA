using DemoListasEnlazadas1;
using System.Security.Principal;

LinkedList lista = new LinkedList();
lista.Add(10);
lista.Add(12);
lista.Add(14);
lista.Add(15);
lista.Addstart(2);
lista.Add(2);
lista.InsertAt(2, 0);
lista.Print();
Console.WriteLine("el objeto 14 es " + lista.Search(14));
//lista.DeleteAt(5);
lista.DeleteValue(2);
lista.Print();
