using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections
{
    public class GenericCollection<T>
    {
        private int index;
        private int size; 
        private T[] items;

        public GenericCollection(T[] collection)
        {
            items = new T[collection.Length];
            this.items = collection;
            this.size = collection.Length;
            this.index = size;
        }
        public GenericCollection()
        {
            index = 0;
            size = 10;
            items = new T[10];
        }
        public void AddItem (T item)
        {
            if(index >= size)
            {
                T[] buff = new T[2 * size];
                for (int i = 0; i < size; i++)
                {
                    buff[i] = items[i];
                }
                items = buff;
                size = size * 2; 
            }
            items[index] = item;
            index++;
        }

        public T[] Items { get { return items; } }
        public int Size { get { return size; } }
        public int Index { get { return index; } }

        public T GetIndex(int index)
        {
            return items[index];
        }
        public void SetIndex(int index, T value)
        {
            items[index] = value;
        }
        public void Swap(int index_i, int index_j)
        {
            T aux = items[index_i];
            items[index_i] = items[index_j];
            items[index_j] = aux;
        }


    }
}
