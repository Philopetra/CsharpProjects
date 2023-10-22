

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

//  Declaring Numeric Testing Variables

string[] valueEntered = new string[courses];
int[] numericScore = new int[courses];

string[] valueEnteredUnit = new string[courses];
int[] numericUnit = new int[courses];


// Declaring Variables

string[] SubjectName = new string[courses];
string [] courseUnit = new string [courses];

string[] courseScore = new string[courses];

int totalUnit = 0;

int totalquotientPoint = 0;
int totalStudentScore = 0;
char[] letterGrade = new char[courses];






for (int i = 0; i < courses; i++)
{
    // Collects Subject Name
    // string? subjectName[i];
    Console.WriteLine($"Enter your Subject{i + 1} Name");
    SubjectName[i] = Console.ReadLine();


    // Collects Subject Units
    // string? courseUnit[i];
    // string valueEnteredUnit[i] = "";
    // int numericUnit[i] = 0;
    bool validNumberUnit = false;

    Console.WriteLine($"Enter the unit for Subject{i + 1}.");

    do
    {
        courseUnit[i] = Console.ReadLine();
        if (courseUnit[i] != null)
        {
            valueEnteredUnit[i] = courseUnit[i];
        }

        validNumberUnit = int.TryParse(valueEnteredUnit[i], out numericUnit[i]);

        if (validNumberUnit == true)
        {
            if (numericUnit[i] <= 0 || numericUnit[i] >= 5)
            {
                validNumberUnit = false;
                Console.WriteLine($" Please enter a number between 1 and 4.");
            }
        }
        else
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
        }
    } while (validNumberUnit == false);


    // Collect Score for the Subject with condition of 0 and 100
    // string? studentScore[i];

    // string valueEntered [i] = "";
    //  int numericScore = 0;


    bool validNumberScore = false;

    Console.WriteLine($"Enter your Subject{i + 1} score. ");

    do
    {
        courseScore[i] = Console.ReadLine();
        if (courseScore[i] != null) 
        {
            valueEntered[i] = courseScore[i];
        }

        validNumberScore = int.TryParse(valueEntered[i], out numericScore[i]);

        if (validNumberScore == true)
        {
            if (numericScore[i] < 1 || numericScore[i] > 100)
            {
                validNumberScore = false;
                Console.WriteLine($"Please enter a number between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
        }
    } while (validNumberScore == false);



    totalquotientPoint = numericUnit[i] * GradePoint(numericScore[i]);
    totalStudentScore += totalquotientPoint;

    letterGrade[i] = myGrade(numericScore[i]);

}


//  CALCULATING THE TOTAL UNIT
for (int j = 0; j < courses; j++)
{
    totalUnit += numericUnit[j];
}




//  CALCULATING AND DISPLAYING THE GRADES
double GPA = (double)totalStudentScore / totalUnit;

Console.WriteLine($"Your Name is {studentName}\n");
Console.WriteLine($"Subject\t\t Unit\t\t Score\t\tGrade\n");
for (int k = 0; k < courses; k++)
{
    Console.WriteLine($"{SubjectName[k]}\t\t {numericUnit[k]}\t\t {numericScore[k]} \t\t{letterGrade[k]}");
}



Console.WriteLine($"GPA: {GPA:N}");

Console.WriteLine();




// CREATION OF METHODS

int GradePoint(int score)
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