using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class MyEnumerator
    {
        private int count;
        _List list;
        public MyEnumerator(_List collection)
        {
            list = collection;
            count = -1;
        }
        public bool MoveNext()
        {
            count++;
            return count < list._items.Length;
        }

        public int Current => list._items[count];
    }

}

