
//  CREATING METHODS

// int[] a = {1,2,3,4,5};

// Console.WriteLine("Contents of Array:");
// PrintArray();


// void PrintArray()
// {
//     foreach (int x in a)
//     {
//         Console.Write($"{x} ");
//     }
//     Console.WriteLine();
// }



// void DisplayRandomNumbers() 
// {
//     Random random = new Random();

//     for (int i = 0; i < 5; i++) 
//     {
//         Console.Write($"{random.Next(1, 100)} ");

//     }

//     Console.WriteLine();
// }

// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers();


// using System;


// int[] times = { 800, 1200, 1600, 2000 };
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");

// // METHOS CALL TO Format and display medicine times
// DisplayTimes();

// Console.WriteLine("Enter new GMT");


// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)

// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     AdjustTimes();
// }
// else
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     AdjustTimes();
// }



// Console.WriteLine("New Medicine Schedule:");

// //  METHOD CALL TO Format and display medicine times
// DisplayTimes();



// // METHOD to Format  time
// void DisplayTimes()
// {
//     /* Format and display medicine times */
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }

//     Console.WriteLine();
// }

// // METHOD TO ADJUS TIME

// void AdjustTimes()
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++)
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }


// // CALL THE METHODS CREATED ABOVE


// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// string[] message = orderStream.Split(",");

// Array.Sort(message);


// foreach(var name in message)
// {
//     if (name.Length == 4)
//     {
//          Console.WriteLine(name);
//     }
//     else
//     {
//          Console.WriteLine($"{name} \t - Error");
//     }
// }




// using System;
// using System.Collections.Generic;

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// // var [] message = orderStream.Split(",");

// var message = orderStream.Split(',').ToList();
// //  Array.Sort(message);
// message.Sort();

// var suspects = "";

// var index = 0;
// foreach(var name in message)
// {
//     if (name.Length != 4)
//     {
//         suspects = name;
//         index = message.IndexOf(suspects);
//         Console.WriteLine($"{suspects} on {index}");
//     }
//     else
//     {
//          Console.WriteLine($"{name}");
         
//          //Console.WriteLine($"{name} is on the position {name[index]} on the List");
//     }
// }



//  using List
// var fibonacciNumbers = new List<int> { 1, 1 };

// while(fibonacciNumbers.Count < 20) 
// {
//     var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
//     var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

//     fibonacciNumbers.Add(previous + previous2);
// }


// foreach (var item in fibonacciNumbers)
// {
//     Console.WriteLine(item);
// }


 Stack<string> myStack = new Stack<string>();

 string pname = "Jollof";
 myStack.Push(pname);
 Console.WriteLine(myStack.Pop());


// var name =  new Stack<char>("FAVOUR");

// Console.WriteLine(name);


// var name = new Stack<char>("FAVOUR");
// string stackAsString = string.Join("", name);
// Console.WriteLine(stackAsString);
