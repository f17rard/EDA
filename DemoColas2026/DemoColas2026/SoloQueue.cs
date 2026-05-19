using System;
using System.Collections.Generic;
using System.Text;

namespace DemoColas2026
{
    internal class SoloQueue
    {
        private Node? head;
        private Node? tail;

        private int size;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public SoloQueue()
        {
            this.head = this.tail = null;
            this.size = 0;
        }

        // otra manera de escribir este metodo es la siguiente:
        // public bool IsEmpty() => this.head == null;
        public bool IsEmpty()
        {
            return this.head == null; //Aqui directamente devuelve el resultado de la comparación
        }

        //los metodos en mayuscula y en minuscula la creación de nodos
        public void Enqueue(int value)
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
            Node? current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
        }

        public Node? GetAt(int pos)
        {
            if (IsEmpty() || pos >= Size)
            {
                return null;
            }

            int i = 0;
            Node? current = head;
            while (current != null)
            {
                if (i == pos)
                {
                    return current;
                }
                i++;
                current = current.Next;
            }
            return null;
        }

        public int Search(int value)
        {
            if (IsEmpty())
            {
                return -1;
            }

            int index = 0;
            Node? current = head;
            while (current != null)
            {
                if (current.Data == value)
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }

        public Node? Dequeue()
        {
            if (IsEmpty())
            {
                return null;
            }
            Node? aux = head;
            head = aux.Next;
            aux.Next = null;
            size--;
            return aux;
        }

        public Node? Peek()
        {
            return head;
        }

        public void clear()
        {
            head = tail =  null;
            size = 0;
        }
    }
}
