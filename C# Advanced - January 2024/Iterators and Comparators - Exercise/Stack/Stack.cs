﻿using System.Collections;

namespace Stack;

internal class Stack<T> : IEnumerable<T>
{
    private const int InitialCapacity = 4;
    private T[] stack;
    public int Count { get; private set; }
    public Stack()
    {
        Count = 0;
        stack = new T[InitialCapacity];
    }
    public void Push(T input)
    {
        if (Count >= stack.Length)
        {
            Resize();
        }
        stack[Count] = input;
        Count++;
    }

    // Doncho's version of Resize()
    //private void Resize()
    //{
    //    T[] temp = new T[InitialCapacity * 2];
    //    for (int i = 0; i < stack.Length; i++)
    //    {
    //        temp[i] = stack[i];
    //    }
    //    stack = temp;
    //}

    //Preferred version of Resize()
    private void Resize()
    {
        T[] temp = new T[InitialCapacity * 2];
        Array.Copy(stack, temp, stack.Length);
        stack = temp;
    }

    public T Peek()
    {
        return stack[Count - 1];
    }
    public T Pop()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException();
        }
        return stack[--Count];
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = Count - 1; i >= 0; i--)
        {
            yield return stack[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}