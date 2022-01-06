using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class BoxOfT<T>
    {
        List<T> elemets;
        public BoxOfT()
        {
            elemets = new List<T>();
        }
        public void Add(T element) 
        {
            elemets.Insert(0, element);
        }
        public T Remove()
        {
            T removedElement = elemets[0];
            elemets.RemoveAt(0);
            return removedElement;
        }
        public int Count {  get {return elemets.Count; } }
    }
}
