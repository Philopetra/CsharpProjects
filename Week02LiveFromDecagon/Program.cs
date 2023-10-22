using System;
using System.Xml.Linq;


int size = 10;
int[] ids = new int[size];
string[] names = new string[size];



//Assigning value to Linera array

/*ids[0] = 1;
names[0] = "John";

// Accessing Value from a linear aaray
var firstId = ids[0];
var firstName = names[0];*/




//Dynamically assigning data from a linear array

/*int index = 0;

foreach (var id in Enumerable.Range(0, size))
{
    ids[index] = id + 1;
    index++;

    //  ids[index++] = id;

}*/



//  Dynamically accessing array Values
/*
foreach (var id in ids) 
{
    Console.WriteLine($"Id - {id} from dynamic access");
}
*/


/*// Another way to dynamically  create, assign and access data from an array

int[] numbers = { 1, 2, 3 };
string[] studentName = { "Jane", "Mark", "Bob" };

foreach (var item in studentName)
{
    Console.WriteLine($"Name: {item}");
}
*/



//   Initializing Multi-Dimensional Array

/*
int[,] board_2 = {
            { 4, 6, 9, 7 },
            { 5, 1, 0, 9 },
            { 1, 7, 9, 12},
            { 1, 3, 5, 1},
};

for (int i = 0; i < board_2.GetLength(0); i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write($"{board_2[i, j]} ");
    }
    Console.WriteLine();
}
*/





/*
// Calculating the Trace of a Matrix

int[,] matrix = new int[,]
{
    { 1, 2, 3, 4 },
    { 5, 6, 7, 8 },
    { 9, 10, 11, 12 },
    { 13, 14, 15, 16 }
};

int trace = 0;

for (int i = 0; i < 4; i++)
{
    trace += matrix[i, i];
}

Console.WriteLine("Trace: " + trace);*/


Student[][] sq019 = new Student[3][];

sq019[0] = new Student[3] {
                            new Student { Id = 1, Name = "Bisi"},
                            new Student { Id = 1, Name = "Banky"},
                            new Student { Id = 1, Name = "Bob"}
                           };

sq019[1] = new Student[2] {
                            new Student { Id = 1, Name = "ChuChu"},
                            new Student { Id = 1, Name = "Tola"}
                           };

sq019[2] = new Student[3] {
                            new Student { Id = 1, Name = "Bibi"},
                            new Student { Id = 1, Name = "Jojo"},
                            new Student { Id = 1, Name = "Juju"}
                           };

var Java = sq019[0];
var Dotnet = sq019[1]; 
var Node = sq019[2];

Console.WriteLine("Jave Devs");
foreach(Student student in Java)
{
    Console.WriteLine($"The student Id is {student.Id} name is {student.Name}");
}

Console.WriteLine("");


Console.WriteLine("Jave Devs");
foreach (Student student in Dotnet)
{
    Console.WriteLine($"The student Id is {student.Id} name is {student.Name}");
}

Console.WriteLine("");

Console.WriteLine("Jave Devs");
foreach (Student student in Node)
{
    Console.WriteLine($"The student Id is {student.Id} name is {student.Name}");
}

Console.WriteLine("");



public class Student
{
    public  int Id ;
    public string Name ;
}