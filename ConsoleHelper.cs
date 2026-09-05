using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment_12_C__Advanced
{
    internal class ConsoleHelper
    {
        public static void PrintGrades<T>(string listName, List<T> list)
        {
            //check for the passed list is not null or empty and not null (refer to address in heap), also have counts/items to print
            if(!string.IsNullOrEmpty(listName) && list is not null && list.Count > 0)
            {
                Console.WriteLine($"{listName}");
                //use Join method in string, which iterate/loop through collection/list, changes each item/element in the collect into string and separate between them with comma (,) separator.
                Console.WriteLine(string.Join(", ", list));
            }
        }

        public static void PrintDictionary<TKey, TValue>(string dictionaryName, Dictionary<TKey, TValue> pairs)
        {
            if (!string.IsNullOrEmpty(dictionaryName) && pairs is not null && pairs.Count > 0)
            {
                foreach(KeyValuePair<TKey, TValue> pair in pairs)
                {
                    Console.WriteLine(pair);
                }
            }
        }

        public static void PrintHashSet<T>(string hashName, HashSet<T> hashSet)
        {
            if (!string.IsNullOrEmpty(hashName) && hashSet is not null && hashSet.Count > 0)
            {
                Console.WriteLine($"{hashName}: {string.Join(", ", hashSet)}");
            }
        }

        public static void PrintQueue<T>(string queueName, Queue<T> queueOrder)
        {
            if (!string.IsNullOrEmpty(queueName) && queueOrder is not null && queueOrder.Count > 0)
            {
                Console.WriteLine($"{queueName}: {string.Join(", ", queueOrder)}");
            }
        }
    }
}
