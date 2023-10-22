using System;
using QuadraticEquApp;


//  x1 = ? and x2 = ?   

Console.WriteLine("Enter the coeffiecient of X^2, a");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the coeffiecient of X, b");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the third coeffiecient, c");
double c = double.Parse(Console.ReadLine());


//double a = 2;
//double b = -5;
// double c = 2;

SquareRoot squareRoot = new SquareRoot();

var temp = squareRoot.TurnNegative(b);

var temp2 = squareRoot.CalculateSqrt(a, b, c);

var temp3  = squareRoot.Divisor(a);

var solution1 = (temp + temp2) / temp3;  

var solution2 = (temp - temp2) / temp3;

Console.WriteLine($"The solutions are X = {solution1} and X = {solution2}");
