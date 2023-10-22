using System;




// Declare the variables

int studentExams = 3;
// Declare the grade and equivalent score
// int gradeA = 5;
// int gradeB = 4;
// int gradeC = 3;
// int gradeD = 2;
// int gradeE = 1;
// int gradeF = 0;

int gradePoint1 = 0;
int gradePoint2 = 0;
int gradePoint3 = 0;


string letterGrade1 = "";
string letterGrade2 = "";
string letterGrade3 = "";



// Collects the Student's Name

string? studentName;
Console.WriteLine("Enter your full name:");
do
{
    studentName = Console.ReadLine();
    //Console.WriteLine($"Your name is {studentName}");
} while (studentName == null);




// Collects First Subject details
string? firstSubject;
Console.WriteLine($"Enter your First Subject Name");
do
{
    firstSubject = Console.ReadLine();
    //Console.WriteLine($"Your name is {firstSubject}");
} while (firstSubject == null);


// Collects first Course Unit with condition of 1 and 4
string? courseUnit1;
string valueEnteredUnit1 = "";
int numericUnit1 = 0;
bool validNumberUnit1 = false;

Console.WriteLine($"Enter the unit for {firstSubject}.");

do
{
    courseUnit1 = Console.ReadLine();
    if (courseUnit1 != null)
    {
        valueEnteredUnit1 = courseUnit1;
    }

    validNumberUnit1 = int.TryParse(valueEnteredUnit1, out numericUnit1);

    if (validNumberUnit1 == true)
    {
        if (numericUnit1 <= 0 || numericUnit1 >= 5)
        {
            validNumberUnit1 = false;
            Console.WriteLine($"You entered {numericUnit1}. Please enter a number between 1 and 4.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumberUnit1 == false);
// courseUnit = Console.ReadLine();




// Collect Score for the first Subject with condition of 0 and 100
string? firstScore;
string valueEntered1 = "";
int numericScore1 = 0;
bool validNumber1 = false;

Console.WriteLine($"Enter your {firstSubject} score. ");

do
{
    firstScore = Console.ReadLine();
    if (firstScore != null)
    {
        valueEntered1 = firstScore;
    }

    validNumber1 = int.TryParse(valueEntered1, out numericScore1);

    if (validNumber1 == true)
    {
        if (numericScore1 <= -1 || numericScore1 >= 101)
        {
            validNumber1 = false;
            Console.WriteLine($"You entered {numericScore1}. Please enter a number between 0 and 100.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber1 == false);

// subjectScore = Console.ReadLine();

if (numericScore1 >= 70)
{
    letterGrade1 = "A";
    gradePoint1 = 5;
}

else if (numericScore1 >= 60)
{
    letterGrade1 = "B";
    gradePoint1 = 4;
}


else if (numericScore1 >= 50)
{
    letterGrade1 = "C";
    gradePoint1 = 3;
}

else if (numericScore1 >= 45)
{
    letterGrade1 = "D";
    gradePoint1 = 2;
}


else if (numericScore1 >= 40)
{
    letterGrade1 = "E";
    gradePoint1 = 1;
}


else
{
    letterGrade1 = "F";
    gradePoint1 = 0;
}

int quotientPoint1 = numericUnit1 * gradePoint1;






// Collects Second Subject details
string? secondSubject;
Console.WriteLine($"Enter your Second Subject Name");
do
{
    secondSubject = Console.ReadLine();
    //Console.WriteLine($"Your name is {firstSubject}");
} while (secondSubject == null);



// Collects second Course Unit with condition of 1 and 4
string? courseUnit2;
string valueEnteredUnit2 = "";
int numericUnit2 = 0;
bool validNumberUnit2 = false;

Console.WriteLine($"Enter the unit for {secondSubject}.");

do
{
    courseUnit2 = Console.ReadLine();
    if (courseUnit2 != null)
    {
        valueEnteredUnit2 = courseUnit2;
    }

    validNumberUnit2 = int.TryParse(valueEnteredUnit2, out numericUnit2);

    if (validNumberUnit2 == true)
    {
        if (numericUnit2 <= 0 || numericUnit2 >= 5)
        {
            validNumberUnit2 = false;
            Console.WriteLine($"You entered {numericUnit2}. Please enter a number between 1 and 4.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumberUnit2 == false);
// courseUnit = Console.ReadLine();




// Collect Score for the Second Subject with condition of 0 and 100
string? secondScore;
string valueEntered2 = "";
int numericScore2 = 0;
bool validNumber2 = false;

Console.WriteLine($"Enter your {secondSubject} score. ");

do
{
    secondScore = Console.ReadLine();
    if (secondScore != null)
    {
        valueEntered2 = secondScore;
    }

    validNumber2 = int.TryParse(valueEntered2, out numericScore2);

    if (validNumber2 == true)
    {
        if (numericScore2 <= -1 || numericScore2 >= 101)
        {
            validNumber2 = false;
            Console.WriteLine($"You entered {numericScore2}. Please enter a number between 0 and 100.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber2 == false);

// subjectScore = Console.ReadLine();

if (numericScore2 >= 70)
{
    letterGrade2 = "A";
    gradePoint2 = 5;
}

else if (numericScore2 >= 60)
{
    letterGrade2 = "B";
    gradePoint2 = 4;
}


else if (numericScore2 >= 50)
{
    letterGrade2 = "C";
    gradePoint2 = 3;
}

else if (numericScore2 >= 45)
{
    letterGrade2 = "D";
    gradePoint2 = 2;
}


else if (numericScore2 >= 40)
{
    letterGrade2 = "E";
    gradePoint2 = 1;
}


else
{
    letterGrade2 = "F";
    gradePoint2 = 0;
}

int quotientPoint2 = numericUnit2 * gradePoint2;






// Collect Third Subject details
string? thirdSubject;
Console.WriteLine($"Enter your third Subject Name");
do
{
    thirdSubject = Console.ReadLine();
    //Console.WriteLine($"Your name is {firstSubject}");
} while (thirdSubject == null);




// Collects the third Course Unit with condition of 1 and 4
string? courseUnit3;
string valueEnteredUnit3 = "";
int numericUnit3 = 0;
bool validNumberUnit3 = false;

Console.WriteLine($"Enter the unit for {thirdSubject}.");

do
{
    courseUnit3 = Console.ReadLine();
    if (courseUnit3 != null)
    {
        valueEnteredUnit3 = courseUnit3;
    }

    validNumberUnit3 = int.TryParse(valueEnteredUnit3, out numericUnit3);

    if (validNumberUnit3 == true)
    {
        if (numericUnit3 <= 0 || numericUnit3 >= 5)
        {
            validNumberUnit3 = false;
            Console.WriteLine($"You entered {numericUnit3}. Please enter a number between 1 and 4.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumberUnit3 == false);
// courseUnit = Console.ReadLine();



// Collect Score for the third Subject with condition of 0 and 100
string? thirdScore;
string valueEntered3 = "";
int numericScore3 = 0;
bool validNumber3 = false;

Console.WriteLine($"Enter your {thirdSubject} score. ");

do
{
    thirdScore = Console.ReadLine();
    if (thirdScore != null)
    {
        valueEntered3 = thirdScore;
    }

    validNumber3 = int.TryParse(valueEntered3, out numericScore3);

    if (validNumber3 == true)
    {
        if (numericScore3 <= -1 || numericScore3 >= 101)
        {
            validNumber3 = false;
            Console.WriteLine($"You entered {numericScore3}. Please enter a number between 0 and 100.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber3 == false);

// subjectScore = Console.ReadLine();

if (numericScore3 >= 70)
{
    letterGrade3 = "A";
    gradePoint3 = 5;
}

else if (numericScore3 >= 60)
{
    letterGrade3 = "B";
    gradePoint3 = 4;
}


else if (numericScore3 >= 50)
{
    letterGrade3 = "C";
    gradePoint3 = 3;
}

else if (numericScore3 >= 45)
{
    letterGrade3 = "D";
    gradePoint3 = 2;
}

else if (numericScore3 >= 40)
{
    letterGrade3 = "E";
    gradePoint3 = 1;
}

else
{
    letterGrade3 = "F";
    gradePoint3 = 0;
}

int quotientPoint3 = numericUnit3 * gradePoint3;




// total Units and total Quotient Points

int totalUnit = numericUnit1 + numericUnit2 + numericUnit3;
int totalquotientPoint = quotientPoint1 + quotientPoint2 + quotientPoint3;

//Calculate the GPA
float GPA = (float) totalquotientPoint / totalUnit;





Console.WriteLine();
Console.WriteLine($"Your Name is {studentName}");
Console.WriteLine($"Subject\t\t Unit\t\t Score\t\tGrade");
Console.WriteLine($"{firstSubject}\t\t {numericUnit1}\t\t {numericScore1} \t\t{letterGrade1}");
Console.WriteLine($"{secondSubject}\t\t {numericUnit2}\t\t {numericScore2} \t\t{letterGrade2}");
Console.WriteLine($"{thirdSubject}\t\t {numericUnit3}\t\t {numericScore3} \t\t{letterGrade3}\n");
Console.WriteLine($"GPA: {GPA}");

Console.WriteLine();




