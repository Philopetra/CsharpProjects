

// // string? readResult;
// // bool validEntry = false;

// // Console.WriteLine($"Enter a string with at least 3 characters:");

// // do
// // {
// //     readResult = Console.ReadLine();
// //     if ((readResult != null) && readResult.Length >= 3)
// //     {
// //         validEntry = true;
// //     }
// //     else
// //     {
// //         Console.WriteLine("Invalid Entry");
// //     }
// // } while (validEntry == false);




// // string? readResult;
// // string valueEntered = "";
// // int numValue = 0;
// // bool validNumber = false;

// // Console.WriteLine("Enter an integer value between 5 and 10");

// // do
// // {
// //     readResult = Console.ReadLine();
// //     if (readResult != null) 
// //     {
// //         valueEntered = readResult;
// //     }

// //     validNumber = int.TryParse(valueEntered, out numValue);

// //     if (validNumber == true)
// //     {
// //         if (numValue <= 5 || numValue >= 10)
// //         {
// //             validNumber = false;
// //             Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
// //         }
// //     }
// //     else 
// //     {
// //         Console.WriteLine("Sorry, you entered an invalid number, please try again");
// //     }
// // } while (validNumber == false);

// // Console.WriteLine($"Your input value ({numValue}) has been accepted.");

// // readResult = Console.ReadLine();





// // string? readResult;
// // // string valueEntered = "";
// // int numValue = 0;
// // bool validNumber = false;

// // Console.WriteLine("Enter an integer value between 5 and 10");

// // do
// // {
// //     readResult = Console.ReadLine();
// //     if (readResult != null) 
// //     // {
// //     //     valueEntered = readResult;
// //     // }

// //     validNumber = int.TryParse(readResult, out numValue);

// //     if (validNumber == true)
// //     {
// //         if (numValue <= 5 || numValue >= 10)
// //         {
// //             validNumber = false;
// //             Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
// //         }
// //     }
// //     else 
// //     {
// //         Console.WriteLine("Sorry, you entered an invalid number, please try again");
// //     }
// // } while (validNumber == false);

// // Console.WriteLine($"Your input value ({numValue}) has been accepted.");

// // readResult = Console.ReadLine();






// // string? readResult;
// // string roleName = "";
// // bool validEntry = false;

// // do
// // {                
// //     Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
// //     readResult = Console.ReadLine();
// //     if (readResult != null) 
// //     {
// //         roleName = readResult.Trim();
// //     }

// //     if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
// //     {
// //         validEntry = true;
// //     }
// //     else
// //     {
// //         Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
// //     }

// // } while (validEntry == false);

// // Console.WriteLine($"Your input value ({roleName}) has been accepted.");
// // readResult = Console.ReadLine();



// // string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// // int stringsCount = myStrings.Length;

// // string myString = "";
// // int periodLocation = 0;

// // for (int i = 0; i < stringsCount; i++)
// // {
// //     myString = myStrings[i];
// //     periodLocation = myString.IndexOf(".");

// //     string mySentence;

// //     // extract sentences from each string and display them one at a time
// //     while (periodLocation != -1)
// //     {

// //         // first sentence is the string value to the left of the period location
// //         mySentence = myString.Remove(periodLocation);

// //         // the remainder of myString is the string value to the right of the location
// //         myString = myString.Substring(periodLocation + 1);

// //         // remove any leading white-space from myString
// //         myString = myString.TrimStart();

// //         // update the comma location and increment the counter
// //         periodLocation = myString.IndexOf(".");

// //         Console.WriteLine(mySentence);
// //     }

// //     mySentence = myString.Trim();
// //     Console.WriteLine(mySentence);
// // }



// // Console.WriteLine("Signed integral types:");

// // Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// // Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// // Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// // Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");



// // Console.WriteLine("");
// // Console.WriteLine("Unsigned integral types:");

// // Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// // Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// // Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// // Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");




// // Console.WriteLine("");
// // Console.WriteLine("Floating point types:");
// // Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// // Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// // Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");



// // byte: working with encoded data that comes from other computer systems or using different character sets.
// // double: working with geometric or scientific purposes. double is used frequently when building games involving motion.
// // System.DateTime for a specific date and time value.
// // System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds.



// // int myInt = 3;
// // Console.WriteLine($"int: {myInt}");

// // decimal myDecimal = (decimal)myInt;
// // Console.WriteLine($"decimal: {myDecimal}");




// // decimal myDecimal = 3.14m;
// // Console.WriteLine($"decimal: {myDecimal}");

// // int myInt = (int)myDecimal;
// // Console.WriteLine($"int: {myInt}");



// string studentName = "Sophia Johnson";
// string course1Name = "English 101";
// string course2Name = "Algebra 101";
// string course3Name = "Biology 101";
// string course4Name = "Computer Science I";
// string course5Name = "Psychology 101";

// int course1Credit = 3;
// int course2Credit = 3;
// int course3Credit = 4;
// int course4Credit = 4;
// int course5Credit = 3;

// int gradeA = 4;
// int gradeB = 3;

// int course1Grade = gradeA;
// int course2Grade = gradeB;
// int course3Grade = gradeB;
// int course4Grade = gradeB;
// int course5Grade = gradeA;

// int totalCreditHours = 0;
// totalCreditHours += course1Credit;
// totalCreditHours += course2Credit;
// totalCreditHours += course3Credit;
// totalCreditHours += course4Credit;
// totalCreditHours += course5Credit;

// int totalGradePoints = 0;
// totalGradePoints += course1Credit * course1Grade;
// totalGradePoints += course2Credit * course2Grade;
// totalGradePoints += course3Credit * course3Grade;
// totalGradePoints += course4Credit * course4Grade;
// totalGradePoints += course5Credit * course5Grade;

// decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;

// int leadingDigit = (int) gradePointAverage;
// int trailingDigits = (int) (gradePointAverage * 100) - (leadingDigit * 100);

// Console.WriteLine($"Student: {studentName}\n");
// Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

// Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
// Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
// Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
// Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
// Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

// Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{trailingDigits}");



// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");


// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);


// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }


// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }

// Console.WriteLine($"Measurement (w/ offset): {50 + result}");


// string value = "bad";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }

// if (result > 0)
//     Console.WriteLine($"Measurement (w/ offset): {50 + result}");




// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// decimal total = 0m;
// string message = "";

// foreach (var item in values)
// {
//     decimal number;
//     if (decimal.TryParse(item, out number))
//     {
//         total += number;
//     }else
//     {
//         message += item;
//     }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");



// int value1 = 12;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// // Your code here to set result1
// // Hint: You need to round the result to nearest integer (don't just truncate)
// int result1 = Convert.ToInt32((decimal)value1 / value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// // Your code here to set result2
// decimal result2 = value2 / (decimal)value3;
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// // Your code here to set result3
// float result3 = value3 / value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");





// string[] pallets = { "B14", "A11", "B12", "A13" };

// Array.Sort(pallets);

// foreach (var item in pallets)
// {
//     Console.WriteLine($"{item}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed....");

// Array.Reverse(pallets);

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"{pallet}");
// }


// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0].ToLower()}");

// Array.Clear(pallets, 0, 2);
// if (pallets[0] != null)
//     Console.WriteLine($"After: {pallets[0].ToLower()}");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }




// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }



// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// string result = new string(valueArray);
// Console.WriteLine(result);


// string value = "ab123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);

// // string result = new string(valueArray);

// string result = String.Join(", ", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }


// string pangram = "The quick brown fox jumps over the lazy dog";
// //convert to array
// char[] valuePan = pangram.ToCharArray();
// //reverse the charArray
// Array.Reverse(valuePan);

// // convert back to string
// string panString = new string(valuePan);
// Console.WriteLine(panString);


// string pangram = "The quick brown fox jumps over the lazy dog";

// // Step 1
// string[] message = pangram.Split(' ');
// int x = message.Length;
// //Step 2
// string[] newMessage = new string[x];


// // Step 3
// for (int i = 0; i < x; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }

// //Step 4
// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);



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


// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// // Console.WriteLine($"{0} {1}!", first, second);
// Console.WriteLine(result);


// string first = "Hello";
// string second = "World";
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);


//  string first = "Hello";
//  string second = "World";
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");



// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");


// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");
// Console.WriteLine($"Measurement: {measurement} units");
// Console.WriteLine($"Measurement: {measurement:N4} units");


// decimal tax = 0.36785m;
// Console.WriteLine($"Tax rate: {tax:P1}");
// Console.WriteLine($"Tax rate: {tax}");


// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// Console.WriteLine(yourDiscount);




// int invoiceNumber = 1201;
// decimal productShares = 1925.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");


// string input = "Pad this";
//  Console.WriteLine(input.PadLeft(12)); // length of the string is 12.
//  Console.WriteLine(input.PadRight(12));

//  Console.WriteLine(input.PadLeft(10, '-'));
//  Console.WriteLine(input.PadRight(12, '-'));




// string paymentId = "769C";
//  string payeeName = "Mr. Stephen Ortega";
//  string paymentAmount = "$5,000.00";

//  var formattedLine = paymentId.PadRight(6);
//  formattedLine += payeeName.PadRight(24);
//  formattedLine += paymentAmount.PadLeft(10);

//  Console.WriteLine(formattedLine);



// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// Console.WriteLine($"Dear {customerName},");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
// Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Console.WriteLine(comparisonMessage);




// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);
// closinPosition -= 1;

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));




// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));



// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');

// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));



string names = "Mice and John";
Console.Write($"The Length is {names.Length}");

var str = names.Substring(0, 5).ToCharArray();

Console.WriteLine($"Check Below");
Console.WriteLine(str);
Console.Write($"The Length is {str.Length}\n\n");

// Testing


foreach (var item in str)
{
    int i = 1;
    Console.WriteLine($"{i} - {item}");
}