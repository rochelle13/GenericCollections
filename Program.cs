using System.Collections.Generic;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            //LISTS
            //we have to specify a data type to its contents, and all elements will have the same datatype
            //OUTPUT: 30,60,90,120

            List<int> GenericList = new List<int>();

            GenericList.Add(30);

            GenericList.Add(60);

            GenericList.Add(90);

            GenericList.Add(120);

            foreach (int x in GenericList)

            {

                Console.WriteLine(x);

            }


            //DICTIONARY
            //store data in key-value pairs, and we have to specify both data types beforehand.
            //OUTPUT: 1 Soda, 2 Burger, 3 Fries, 4 Onion Rings 

            Dictionary<int, string> GenericDictionary = new Dictionary<int, string>();

            GenericDictionary.Add(1, "Soda");

            GenericDictionary.Add(2, "Burger");

            GenericDictionary.Add(3, "Fries");

            GenericDictionary.Add(4, "Onion Rings");

            foreach (KeyValuePair<int, string> kvp in GenericDictionary)

            {

                Console.WriteLine(kvp.Key + " " + kvp.Value);

            }


            //SORTED LISTS 
            //stores a key-value pair and automatically sorts its elements in ascending order based on their keys
            //In the generic Sorted list, we have to specify the datatypes of its content beforehand
            //OUTPUT: American Burger, Lime Soda, French Fries, Onion Rings 
            SortedList<string, string> GenericSortedList = new SortedList<string, string>();

            GenericSortedList.Add("American", "Burger");

            GenericSortedList.Add("Lime", "Soda");

            GenericSortedList.Add("French", "Fries");

            GenericSortedList.Add("Onion", "Rings");

            foreach (KeyValuePair<string, string> kvp in GenericSortedList)

            {

                Console.WriteLine(kvp.Key + " " + kvp.Value);

            }

            //STACK 
            //Values are kept in Stack using LIFO (Last In First Out)
            //It offers the Push() and Pop() & Peek() methods to add and retrieve values, respectively.
            //In generic Stack, we have to specify the datatypes of its content beforehand
            //OUTPUT: Well done, Medium, Medium Rare, Rare
            Stack<string> steak = new Stack<string>();

            steak.Push("Rare");

            steak.Push("Medium Rare");

            steak.Push("Medium");

            steak.Push("Well done");

            foreach (string s in steak)

            {

                Console.WriteLine(s);

            }

            //QUEUE
            //Values are kept in a queue in a FIFO fashion (First In, First Out)
            //The sequence in which the values were inserted is preserved
            //It offers the Enqueue() and Dequeue() methods to add and remove values from the collection
            //In the generic queue, we have to specify the datatypes of its content beforehand
            //OUTPUT: Mark, Bill, Xavier, Michael
            Queue<string> GenericQueue = new Queue<string>();

            GenericQueue.Enqueue("Mark");

            GenericQueue.Enqueue("Bill");

            GenericQueue.Enqueue("Xavier");

            GenericQueue.Enqueue("Michael");

            foreach (string s in GenericQueue)

            {

                Console.WriteLine(s);

            }

            
        }
    }
}
