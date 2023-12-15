using EstructurasDatosFormulario;
using System;

public class StackStatic
{
    private const int MaxSize = 10;
    private int[] stackArray;
    private int top;

    public StackStatic()
    {
        stackArray = new int[MaxSize];
        top = -1;
    }

    public void Push(int data)
    {
        if (top < MaxSize - 1)
        {
            stackArray[++top] = data;
        }
        else
        {
            Console.WriteLine("La pila está llena. No se puede agregar más elementos.");
        }
    }

    public int Pop()
    {
        if (top >= 0)
        {
            return stackArray[top--];
        }
        else
        {
            Console.WriteLine("La pila está vacía. No se puede extraer más elementos.");
            return -1;
        }
    }

    public bool IsEmpty()
    {
        return top == -1;
    }
}


public class StackDynamic
{
    private Node top;

    public StackDynamic()
    {
        top = null;
    }

    public void Push(int data)
    {
        Node nuevoNodo = new Node(data);
        nuevoNodo.Next = top;
        top = nuevoNodo;
    }

    public int Pop()
    {
        if (top != null)
        {
            int data = top.Data;
            top = top.Next;
            return data;
        }
        else
        {
            Console.WriteLine("La pila está vacía. No se puede extraer más elementos.");
            return -1;
        }
    }

    public bool IsEmpty()
    {
        return top == null;
    }
}