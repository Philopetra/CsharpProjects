

/*int i = 14;

int j = 14;

*//*int k = 20;*//*


bool result = i >= j;


*//*Console.WriteLine(i);*//*

Console.WriteLine(result);
*/



/*char x = 'B';

string y = "He called me \"good\"";

Console.WriteLine(y);*/




/*string i = "Chaos";
string j = "Chao";

int result = string.Compare(i, j);
Console.WriteLine(result);*/



/*public class student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public char studentGrade { get; set; }
}

 */



/*//  Comparism
string x = "8";
string y = "7";

bool result = x.CompareTo(y);
Console.WriteLine(result);*/


/*//  Substring
string x = "Murphy";

string result  = (String)x.Substring(0, 3);

char[] chars = result.ToCharArray();
Array.Reverse(chars);
Console.WriteLine(chars);*/

/*using System;
    
    
    string? minutes;
Console.WriteLine("Enter your time in Minutes");

    int hours = 0;
    int remainingMinutes;

    minutes = Console.ReadLine();
    int minuteNumber = int.Parse(minutes);

if (minuteNumber == null)
    Console.WriteLine("Enter a value");

if (minuteNumber < 60)
    Console.WriteLine($"{minuteNumber} minutes is equal to {hours} hour and {minuteNumber} minutes");

    if(minuteNumber >= 60)
        {
        hours = minuteNumber / 60;
        remainingMinutes = minuteNumber % 60;
        Console.WriteLine($"{minuteNumber} minutes is equal to {hours} hours and {remainingMinutes} minutes");
        }*/


// string? numberChecker;

// Console.WriteLine("Enter a Number");
// numberChecker = Console.ReadLine();
// int number =  int.Parse(numberChecker);

// if (number % 2 == 0)
// {
//     Console.WriteLine($"{number} is an even number.");

// }

// else

//     Console.WriteLine($"{number} is an odd number");


using System.Globalization;

// Console.WriteLine("Enter your age!");

// int age = Int32.Parse(Console.ReadLine());

// if ((age >= 12) && (age < 65))
// {
//     Console.WriteLine("You can enter");
// }

// Console.WriteLine("What is the movie rating?");

// char rating = char.Parse(Console.ReadLine());

// if (((age <=12) || (age >= 65)) && rating =='G')
// {
//     Console.WriteLine("You get a discount");
// }
// else
// {
//     Console.WriteLine("You don't get a discount");
// }

//  int [] Numbers = new int [5];

//  for (int i = 0; i < Numbers.Length; i++)
//  {
//     Console.WriteLine("Enter a number");
//     Numbers[i] = Int32.Parse(Console.ReadLine());

//  }

//  Console.WriteLine("These are the items in Numbers");

// foreach(var item in Numbers)
// {

//     Console.Write(item + " ");
// }





// int[] Numbers = new int[] { 5, 6, 7, 8, 9, 10 };

// for (int i = 0; i < Numbers.Length; i++)
// {

//     if (Numbers[i] % 2 == 0)
//     {
//         int[] even = Numbers;
//         Console.WriteLine($"{even[i]}");

//     }
//     // Console.WriteLine(Numbers[i]);
// }


var Numbers = new int [] { 5, 6, 7, 8, 9, 10 };

var even = new int [6];
int x = 0;

for (int i = 0; i < Numbers.Length; i++)
{

    if (Numbers[i] % 2 == 0)
    {
       even[x] = Numbers[i];
       x++;
    }
    // Console.WriteLine(Numbers[i]);
}

Console.WriteLine("The Even Brethen");

foreach (var item in even)
{
    Console.Write(item + " ");
}

