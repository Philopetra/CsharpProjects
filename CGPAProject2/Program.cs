

// Collecting Student's Name;
string? studentName;
do
{
    Console.WriteLine($"Enter your Name");
    studentName = Console.ReadLine();
} while (studentName == null);


// Collecting the Valid number of courses
Console.WriteLine("Enter your number of Courses");
//  string valueEntered = "";
int courses = 0;
bool validNumber = false;

do
{
    string courseNumber = Console.ReadLine();

    validNumber = int.TryParse(courseNumber, out courses);

    if (validNumber == true)
    {
        if (Math.Abs(courses) < 3 || Math.Abs(courses) > 5)
        {
            validNumber = false;
            Console.WriteLine($"You entered {courses}. Please enter a number between 3 and 5.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);


// Declaring Variables

string[] SubjectName = new string[courses];
int[] courseUnit = new int[courses];

int[] courseScore = new int[courses];


int totalUnit = 0;
int totalquotientPoint = 0;
int totalStudentScore = 0;
char[] letterGrade = new char[courses];






for (int i = 0; i < courses; i++)
{
    Console.WriteLine($"Enter your Subject{i + 1} Name");
    SubjectName[i] = Console.ReadLine();



    Console.WriteLine($"Enter the unit for Subject{i + 1}.");

    courseUnit[i] = Int32.Parse(Console.ReadLine());


    Console.WriteLine($"Enter your Subject{i + 1} score. ");

    courseScore[i] = Int32.Parse(Console.ReadLine());


    totalquotientPoint = courseUnit[i] * gradepoint(courseScore[i]);
    totalStudentScore += totalquotientPoint;

    letterGrade[i] = myGrade(courseScore[i]);

}


//  CALCULATING THE TOTAL UNIT
for (int j = 0; j < courses; j++)
{
    totalUnit += courseUnit[j];
}


//  CALCULATING AND DISPLAYING THE GRADES

double GPA = (double)totalStudentScore / totalUnit;

Console.WriteLine($"Your Name is {studentName}");
Console.WriteLine($"Subject\t\t Unit\t\t Score\t\tGrade\n");
for (int k = 0; k < courses; k++)
{
    Console.WriteLine($"{SubjectName[k]}\t\t {courseUnit[k]}\t\t {courseScore[k]} \t\t{letterGrade[k]}");
}



Console.WriteLine($"GPA: {GPA:N}");

Console.WriteLine();




// CREATION OF METHODS

int gradepoint(int score)
{
    if (score >= 70)
    {
        int points = 5;
        return points;
    }
    else if (score >= 60)
    {
        int points = 4;
        return points;
    }

    else if (score >= 50)
    {
        int points = 3;
        return points;
    }

    else if (score >= 45)
    {
        int points = 2;
        return points;
    }

    else if (score >= 40)
    {
        int points = 1;
        return points;
    }

    else
    {
        int points = 0;
        return points;
    }

}


char myGrade(int score)
{
    if (score >= 70)
    {
        char grade = 'A';
        return grade;
    }
    else if (score >= 60)
    {
        char grade = 'B';
        return grade;
    }

    else if (score >= 50)
    {
        char grade = 'C';
        return grade;
    }

    else if (score >= 45)
    {
        char grade = 'D';
        return grade;
    }

    else if (score >= 40)
    {
        char grade = 'E';
        return grade;
    }

    else
    {
        char grade = 'F';
        return grade;
    }

}