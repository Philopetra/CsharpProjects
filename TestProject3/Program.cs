using System;
using System.Collections;
using System.Collections.Generic;

namespace Week02TestProject
{
    class Program
    {
        static void Main(string[] args)
        {

            /* var names = new List<string> { "<name>", "Ana", "Felipe" };
             foreach (var name in names)
             {
                 Console.WriteLine($"Hello {name.ToUpper()}!");

             }*/

            /*     var names = new List<string> { "James", "Mike", "Bond" };
                 for(int i = 0; i < names.Count; i++) 
                 {
                     //names.Add(names[i]);
                     Console.WriteLine($"{names[i].ToUpper()!}");
                 }*/

            /*var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");

            }*/



            /*
                        int[] names2 = new int[5] { };

                        List<string> listName = new List<string> { };*/

            // METHOD DECLARATION

            /*           WorkWithStrings();

                       void WorkWithStrings()
                       {
                           var names = new List<string> { "<name>", "Ana", "Felipe" };
                           foreach (var name in names)
                           {
                               Console.WriteLine($"Hello {name.ToUpper()}!");
                           }

                           Console.WriteLine();
                           names.Add("Maria");
                           names.Add("Bill");
                           names.Remove("Ana");
                           foreach (var name in names)
                           {
                               Console.WriteLine($"Hello {name.ToUpper()}!");
                           }

                           Console.WriteLine($"My name is {names[0]}");
                           Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");

                           Console.WriteLine($"The list has {names.Count} people in it");

                           var index = names.IndexOf("Bill");
                           if (index == -1)
                           {
                               Console.WriteLine($"When an item is not found, IndexOf returns {index}");
                           }
                           else
                           {
                               Console.WriteLine($"The name {names[index]} is at index {index}");
                           }

                           index = names.IndexOf("Not Found");
                           if (index == -1)
                           {
                               Console.WriteLine($"When an item is not found, IndexOf returns {index}");
                           }
                           else
                           {
                               Console.WriteLine($"The name {names[index]} is at index {index}");

                           }

                           names.Sort();
                           foreach (var name in names)
                           {
                               Console.WriteLine($"Hello {name.ToUpper()}!");
                           }
                       }*/




            //  using List
            /*var fibonacciNumbers = new List<int> { 1, 1 };

            while(fibonacciNumbers.Count < 20) 
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }


            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }*/


            //  ArrayList allows different data type. E.g 1, "what", 'w'

            //ArrayList arrayList = new ArrayList();

            // arrayList.Add(1);
            // arrayList.Add("John");
            // arrayList.Add(10);
            // arrayList.Add('r');   

            // for (int i = 0; i < arrayList.Count; i++) 
            // {
            //     Console.WriteLine((arrayList[i]));
            // }



            //   Lists
            Console.WriteLine("This is List Array");

            List<Person> myList = new List<Person>();
            myList.Add(new Person { Name = "John", age = 44, GPA = 4.5m, Id = 002 });


            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(@$"
                                    The Name: {myList[i].Name}
                                    The Id: {myList[i].Id}
                                ");
            }




            //   STACK
            //  1, 2, 3, 4, 5, 6, 7

            Stack<int> numbers = new Stack<int>(Enumerable.Range(0, 9));


            class Person
        {
            public string Name;
            public int Id;
            public int age;
            public decimal GPA;
        }




    }

}
