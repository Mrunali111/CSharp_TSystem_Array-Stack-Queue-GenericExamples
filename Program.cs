using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Day3_2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3- Rows
            // 7 - Coloumns
            //int[,] details = new int[3, 7]
            //{
            //    {100,101,105,102,106,107,109},
            //    {100,101,105,102,106,107,109},
            //    {100,101,105,102,106,107,109}
            //};


            //Console.WriteLine("====================Details Display==================");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 7; j++)
            //    {
            //        Console.Write(details[i, j] + "    ");
            //    }
            //    Console.WriteLine();
            //}




            //{
            //    {85,36,79},
            //    {55,36,85},
            //    {87,99,23},
            //    {96,23,15},
            //    {45,25,66},
            //    {11,22,33}
            //};

            //Console.WriteLine("====================List Display==================");
            //for (int i = 0; i < 6; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(list[i, j] + "  ");
            //    }
            //    Console.WriteLine();
            //}

            int[,] list = new int[6, 3];
            Console.WriteLine("====================List Display==================");
            for (int i = 0; i < list.GetLength(0); i++)
            {
                for (int j = 0; j < list.GetLength(1); j++)
                {
                    Console.Write(list[i, j] + "  ");
                }
                Console.WriteLine();
            }


            //Console.WriteLine("====================ArrayList Display==================");
            //ArrayList list2 = new ArrayList();
            //list2.Add(10);               //index [0]
            //list2.Add(12.23);
            //list2.Add("Mrunali");
            //list2.Add(23);
            //list2.Add("Anjali");
            //list2.Add(true);



            //list2.Insert(1, 56);
            //list2.Remove(12.23);
            ////list2.RemoveAt(1);
            ////list2.RemoveRange(2, 5);
            //Console.WriteLine("Count "+list2.Count);
            //Console.WriteLine("Memory "+list2.Capacity);

            //Console.WriteLine("====================");
            //foreach (object item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("============================Stack and Queue====================");

            Stack stack = new Stack();
            stack.Push("mrunali");
            stack.Push(12);
            stack.Push(23.12);
            stack.Push(false);

            stack.Pop();

            Console.WriteLine("Stack Elements are : ");
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==========================");

            Queue queue = new Queue();
            queue.Enqueue(55);
            queue.Enqueue("Taksh");
            queue.Enqueue(55.31);
            queue.Enqueue(true);

            queue.Dequeue();
            

            Console.WriteLine("Queue Elements are :");
            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("============================HashTable===============================");
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "USA");
            hashtable.Add(2, "UK");
            hashtable.Add(56, "IND");
            hashtable.Add(69, "AUS");

            hashtable.Remove(69);

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key+"  "+item.Value);
            }

            Console.WriteLine("============================Generic Concept===============================");

            Console.WriteLine("===================Generic List===================");
            List<String> lisst = new List<String>();

            List<Product> products = new List<Product>();
            Product p1 = new Product(101, "Mobile", 25000);
            Product p2 = new Product(102, "TV", 35000);
            Product p3 = new Product(101, "Laptop", 45000);
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            foreach (Product item in products)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine("==========OR================");
            //List<Product> productlist = new List<Product>()
            //{
            //    new Product(101,"Mobile",25000),
            //    new Product(102,"TV",35000),
            //    new Product(101,"Laptop",45000)
            //};

            Console.WriteLine("===================Generic Stack===================");

            Stack<string> stackG = new Stack<string>();
            stackG.Push("Mrunali");
            stackG.Push("Atul");
            stackG.Push("Taksh");
            stackG.Push("Aman");
            stackG.Push("Shri");

            stackG.Pop();
            stackG.Count();

            Console.WriteLine("Stack Elements are : ");
            foreach (object item in stackG)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===================Generic Queue===================");
            Queue<int> queueG = new Queue<int>();
            queueG.Enqueue(126);
            queueG.Enqueue(153);
            queueG.Enqueue(869);
            queueG.Enqueue(563);
            queueG.Enqueue(986);

            queueG.Dequeue();

            Console.WriteLine("Queue Elements are :");
            foreach (object item in queueG)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===================Generic Dictionary===================");

            Dictionary<int, string> prolist = new Dictionary<int, string>();
            prolist.Add(1, "Mrunali");
            prolist.Add(2, "Atul");
            prolist.Add(3, "Taksh");
            prolist.Add(4, "Shreya");
            prolist.Add(5, "Shri");

            foreach (KeyValuePair<int, string> item in prolist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===================Generic Class===================");

            Generic<int> obj = new Generic<int>(222);
            Console.WriteLine(obj.GetData());

            Generic<string> obj2 = new Generic<string>("Mrunali");
            Console.WriteLine(obj2.GetData());

            Generic<Product> obj3 = new Generic<Product>(new Product(20, "Moblie", 30000));
            Console.WriteLine(obj3.GetData());

            Console.WriteLine("============================Property Concept===============================");

            Department d1= new Department();
            d1.Id = 1;
            d1.Dname = "HR";
            Console.WriteLine(d1.Id+" "+d1.Dname);

            Department d2= new Department { Id=2,Dname="CEO"};
            Console.WriteLine(d2.Id+" "+d2.Dname );

            Console.ReadLine();

        }
    }
}
