﻿namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> box = new Stack<T>();

        public void Add(T element)
        {
            box.Push(element);
        }
        public T Remove()
        {
            return box.Pop();
        }

        public int Count { get { return box.Count; } }
    }
}
