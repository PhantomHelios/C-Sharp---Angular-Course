using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    public class MyDictionary<K, V>
    {

        private K[] keys;
        private V[] values;
        private int size;

        public MyDictionary()
        {
            size = 0;
            keys = new K[size];
            values = new V[size];
        }

        public void Add(K key, V value)
        {
            K[] tempKeys = keys;
            V[] tempValues = values;

            size++;

            keys = new K[size];
            values = new V[size];

            for (int i = 0; i < size - 1; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[size - 1] = key;
            values[size - 1] = value;
        }

        public void List()
        {
            for (int i = 0; i < size; i++)
                Console.WriteLine(keys[i] + " " + values[i]);
        }
    }
}
