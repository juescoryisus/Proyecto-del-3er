using System;
using System.Text;

namespace EstructurasDatosFormulario
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }
    }

    public class SimpleList
    {
        private Node head;

        public SimpleList()
        {
            head = null;
        }

        public void AgregarElemento(int data)
        {
            Node nuevoNodo = new Node(data);
            if (head == null)
            {
                head = nuevoNodo;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = nuevoNodo;
            }
        }

        public string MostrarLista()
        {
            StringBuilder result = new StringBuilder();
            Node temp = head;
            while (temp != null)
            {
                result.Append(temp.Data).Append(" ");
                temp = temp.Next;
            }
            return result.ToString();
        }
    }

    public class DoubleList
    {
        private Node head;
        private Node tail;

        public DoubleList()
        {
            head = null;
            tail = null;
        }

        public void InsertarNodo(int data)
        {
            Node nuevoNodo = new Node(data);
            if (head == null)
            {
                head = nuevoNodo;
                tail = nuevoNodo;
            }
            else
            {
                tail.Next = nuevoNodo;
                nuevoNodo.Previous = tail;
                tail = nuevoNodo;
            }
        }

        public string DesplegarLista()
        {
            StringBuilder result = new StringBuilder();
            Node temp = head;
            while (temp != null)
            {
                result.Append(temp.Data).Append(" ");
                temp = temp.Next;
            }
            return result.ToString();
        }
    }

    public class CircularList
    {
        private Node head;

        public CircularList()
        {
            head = null;
        }

        public void InsertarNodo(int data)
        {
            Node nuevoNodo = new Node(data);
            if (head == null)
            {
                head = nuevoNodo;
                head.Next = head;
            }
            else
            {
                Node temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = nuevoNodo;
                nuevoNodo.Next = head;
            }
        }

        public string DesplegarLista()
        {
            if (head == null)
            {
                return string.Empty;
            }

            StringBuilder result = new StringBuilder();
            Node temp = head;
            do
            {
                result.Append(temp.Data).Append(" ");
                temp = temp.Next;
            } while (temp != head);

            return result.ToString();
        }
    }

    public class CircularDoublyLinkedList
    {
        private Node head;

        public CircularDoublyLinkedList()
        {
            head = null;
        }

        public void InsertarNodo(int data)
        {
            Node nuevoNodo = new Node(data);
            if (head == null)
            {
                head = nuevoNodo;
                head.Next = head;
                head.Previous = head;
            }
            else
            {
                Node tail = head.Previous;
                tail.Next = nuevoNodo;
                nuevoNodo.Previous = tail;
                nuevoNodo.Next = head;
                head.Previous = nuevoNodo;
            }
        }

        public string DesplegarLista()
        {
            if (head == null)
            {
                return string.Empty;
            }

            StringBuilder result = new StringBuilder();
            Node temp = head;
            do
            {
                result.Append(temp.Data).Append(" ");
                temp = temp.Next;
            } while (temp != head);

            return result.ToString();
        }
    }

}
