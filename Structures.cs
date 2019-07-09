using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basics
{
    class Structures
    {
        public static ConcurrentDictionary<int, int> items = new ConcurrentDictionary<int, int>();
        public static void List()
        {
            Console.WriteLine("\nList Example:\n");
            List<String> customers = new List<String>();
            customers.Add("Kim");
            customers.Add("Jim");
            customers.Add("Lim");
            Console.WriteLine(customers.Count);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            };
            Console.WriteLine(customers[1]);
        }
        public static void Dictionary()
        {
            Console.WriteLine("\nDictonary Example:\n");
            Dictionary<String, String> config = new Dictionary<String, String>();
            config.Add("resoultion", "1920x1080");
            config.Add("title", "Website");
            Console.WriteLine(config["title"]);
            foreach (var setting in config)
            {
                Console.WriteLine(setting.Value);
            }
        }
        // Allows for multithreading
        // Dictonary will try to add to the same and fail
        public static void Concurrent()
        {
            Console.WriteLine("\nConcurrent thread Example:\n");
            Thread thread1 = new Thread(new ThreadStart(AddItem));
            Thread thread2 = new Thread(new ThreadStart(AddItem));
            thread1.Start();
            thread2.Start();
        }
        public static void AddItem()
        {
            items.TryAdd(1, 2);
            Console.WriteLine(items.Count);
        }
        public static void BitArray()
        {
            Console.WriteLine("\nBitArray Example:\n");
            bool[] preload = new bool[3] { false, true, false };
            BitArray enemyGrid = new BitArray(preload);

            // BitArray enemyGrid = new BitArray(3);
            // enemyGrid[0] = false;
            // enemyGrid[1] = true;
            // enemyGrid.Set(2, false);
            foreach (var item in enemyGrid)
            {
                Console.WriteLine(item);
            }

        }
        public static void Tuple()
        {
            Tuple<int, string, bool> myTuple = new Tuple<int, string, bool>(1, "hello", true);
            // var myTuple =Tuple.create(1, "hello", true);
            Console.WriteLine(myTuple.Item2);
        }
        public static void Stack()
        {
            Console.WriteLine("\nStack Example:\n");
            Stack<String> pancakes = new Stack<String>();
            pancakes.Push("first pancake");
            pancakes.Push("second pancake");
            pancakes.Push("last pancake");
            //foreach (var pancake in pancakes)
            //{
            //    Console.WriteLine(pancake);
            //}
            //removes the last item
            Console.WriteLine("pop removes last and prints");
            Console.WriteLine(pancakes.Pop());
            // doesn't remove
            Console.WriteLine("Peek looks at current last");
            Console.WriteLine(pancakes.Peek());
            Console.WriteLine("Peek doesnt remove");
            Console.WriteLine(pancakes.Peek());
        }
        public static void Queue()
        {
            Console.WriteLine("\nQueue Example:\n");
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            //foreach (var item in myQueue)
            //{
            //    Console.WriteLine(item);

            Console.WriteLine("Dequeue removes first and prints");
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine("Peek looks at current first");
            Console.WriteLine(myQueue.Peek());
            Console.WriteLine("Peek doesnt remove");
            Console.WriteLine(myQueue.Peek());

        }
        // Deduplicates
        public static void HashSet()
        {
            Console.WriteLine("\nHashSet Example:\n");
            var myHash = new HashSet<string>();
            myHash.Add("hello");
            myHash.Add("hello");
            String[] s = new String[] { "hello" };
            Console.WriteLine("Same Item added twice. Length of Hash:");
            Console.WriteLine(myHash.Count);
            Console.WriteLine("Overlaps:");
            Console.WriteLine(myHash.Overlaps(s));
        }
    }
}
