using System;
using System.Collections;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To C# Collections");

            doListDemo();
            doStackDemo();
            doDictionaryDemo();
            doQueueDemo();
            doSetDemo();
        }
        private static void doSetDemo()
        {
            Console.WriteLine("\n doSetDemo");

            var set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add("Ajay");

            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        private static void doQueueDemo()
        {
            Console.WriteLine("\ndoQueueDemo");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Vijay Raj");
            queue.Enqueue("Jaishankar");
            queue.Enqueue("Raj");
            Console.WriteLine("Head:" + queue.Peek());
            Console.WriteLine("\n Iterating the queue elements: ");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue elements:" + dequeue);
            Console.WriteLine("\n Iterating the queue elements after dequeue one elements");
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        private static void doDictionaryDemo()
        {
            Console.WriteLine("\ndoDictionaryDemo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Rahul");
            dictionary.Add(102, "Vijay");
            Console.WriteLine("Access value using key(key=101):" + dictionary[101]);
            Console.WriteLine("\n Iterating Dictionary:");

            foreach (var element in dictionary)
            {
                Console.WriteLine("Key= " + element.Key + " & Value =" + element.Value);
            }
        }
        private static void doStackDemo()
        {
            Console.WriteLine("\ndoStackDemo: \n");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garima");
            string pop = stack.Pop();

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Poped Element: " + pop);
        }
        private static void doListDemo()
        {
            Console.WriteLine("doListDemo: \n");
            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
       
    }
}