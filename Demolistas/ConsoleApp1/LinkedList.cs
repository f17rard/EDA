using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security;
using System.Text;

namespace DemoListasEnlazadas1
{
    internal class LinkedList
    {
        private Node head;
        private Node tail;

        private int size;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public LinkedList()
        {
            this.head = this.tail = null; //conviene tener una referencia a la cola para que sea un metodo constante
            Size = 0;
        }

        // otra manera de escribir este metodo es la siguiente:
        // public bool IsEmpty() => this.head == null;
        public bool IsEmpty()
        {
            return this.head == null; //Aqui directamente devuelve el resultado de la comparación
        }

        //los metodos en mayuscula y en minuscula la creación de nodos
        public void Add(int value)
        {
            Node aux = new Node(value);

            if (IsEmpty())
            {
                head = tail = aux;
                Size++;
                return;
            }

            //si ya habia nodo
            tail.Next = aux;
            tail = aux;
            Size++;
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La lista no tiene nada vo");
                return;
            }
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
        }

        public void Addstart(int value)
        {
            Node aux = new Node(value);

            if (IsEmpty())
            {
                head = tail = aux;
                Size++;
                return;
            }
            aux.Next = head;
            head = aux;
            Size++;
        }

        public Node GetAt(int pos)
        {
            if (IsEmpty() || pos>=Size)
            {
                return null;
            }

            int i = 0;
            Node current = head;
            while(current != null)
            {
                if(i == pos)
                {
                    return current;
                }
                i++;
                current = current.Next;
            }
            return null;
        }

        public void InsertAt(int pos, int value)
        {
            if (pos > Size)
            {
                Console.WriteLine("Posicion no valida");
                return;
            }
            if (IsEmpty())
            {
                Add(value);
                return;
            }
            Node newNode = new Node(value);
            Node previus = GetAt(pos - 1);
            Node aux = previus.Next;
            previus.Next = newNode;
            newNode.Next = aux;
            Size++;

        }

        public int Search(int value)
        {
            if (IsEmpty())
            {
                return -1;
            }

            int index = 0;
            Node current = head;
            while (current != null)
            {
                if(current.Data == value)
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }

        public bool DeleteFirst()
        {
            if (IsEmpty())
            {
                return false;
            }
            Node current = head;
            head = current.Next;
            current.Next = null;
            size--;
            return true;
        }

        public bool DeleteLast()
        {
            if (IsEmpty()) { return false; }
            if (size == 1) { return DeleteFirst(); }

            Node aux = GetAt(Size - 2);
            aux.Next = null;
            tail = aux;
            size--;
            return true;
        }

        public bool DeleteAt(int pos)
        {
            if (IsEmpty() || pos > size || pos<0)
            {
                return false;
            }

            if (pos == size-1) //borrar el ultimo
            {
                return DeleteLast();
            }

            if (pos == 0) //borrar el primero
            {
                return DeleteFirst();
            }

            Node aux = GetAt(pos-1);
            Node deleted = aux.Next;
            aux.Next = deleted.Next;
            deleted = null;
            size--;
            return false;
        }

        public bool DeleteValue(int value)
        {
            if (IsEmpty())
            {
                return false;
            }

            int pos = Search(value);
            if(pos == -1) { return false; }

            return DeleteAt(pos);
        }
    }
}
