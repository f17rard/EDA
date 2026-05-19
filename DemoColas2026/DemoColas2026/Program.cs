using DemoColas2026;
using System.ComponentModel.Design;

SoloQueue cola = new SoloQueue();
int Elmenu;

do
{
    Console.Clear();
    Console.WriteLine("Elija la opcion que quiera realizar utilizando los números del menú");
    Console.WriteLine("""
    -------------------menu---------------------
    1. Enqueue
    2. Dequeue
    3. Peek (Devuelve el primer nodo de la cola)
    4. print (imprimir la cola)
    5. Clear (Borra la cola)
    6. Salir
    --------------------------------------------
    """);

    Console.Write("Digite un numero del menú: ");

    Elmenu = int.Parse(Console.ReadLine());

    switch (Elmenu)
    {
        case 1:
            Console.Write("ingrese el valor a encolar");
            int valor = int.Parse(Console.ReadLine());
            cola.Enqueue(valor);
            Console.WriteLine("Valor encolado" + valor);
            break;
        case 2:
            Node? deleted = cola.Dequeue();
            if (deleted != null)
            {
                Console.WriteLine("Elemento " + deleted + " eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("cola vacia, no se puede desencolar");
            }
            break;
        case 3:
            Console.WriteLine("El inicio de la cola es: " + cola.Peek().Data);
            break;
        case 4:
            cola.Print();
            break;
        case 5:

            break;
    }
    Console.ReadKey();
} while (Elmenu!= 6);