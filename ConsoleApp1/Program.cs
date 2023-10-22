


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
            Console.WriteLine($"You entered {courses}. Please enter a number between 0 and 100.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);




int gradePoint;
string letterGrade = "";


string? studentName;
Console.WriteLine("Enter your full name:");
do
{
    studentName = Console.ReadLine();
    //Console.WriteLine($"Your name is {studentName}");
} while (studentName == null);




void StudentDetails()
{
    /* Format and display medicine times */
    StudentSubject();


    SubjectUnitValue();

    SubjectScore();



}




void StudentSubject()
{
    /* Format and display medicine times */
    string? subject;

    do
    {
        Console.WriteLine($"Enter your Subject Name");
        Subject = Console.ReadLine();
        Console.WriteLine(subject);
    } while (Subject == null);

}


void SubjectUnitValue()
{
    string? courseUnit;
    string valueEnteredUnit = "";
    int numericUnit = 0;
    bool validNumberUnit = false;

    Console.WriteLine($"Enter the unit for Subject.");

    do
    {
        courseUnit = Console.ReadLine();
        if (courseUnit != null)
        {
            valueEnteredUnit = courseUnit;
        }

        validNumberUnit = int.TryParse(valueEnteredUnit, out numericUnit);

        if (validNumberUnit == true)
        {
            if (numericUnit <= 0 || numericUnit >= 5)
            {
                validNumberUnit = false;
                Console.WriteLine($"You entered {numericUnit}. Please enter a number between 1 and 4.");
            }
        }
        else
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
        }
    } while (validNumberUnit1 == false);

    Console.WriteLine($"Your Subject Unit is {numericUnit}");

}


void SubjectScore()
{
    // Collect Score for the first Subject with condition of 0 and 100
    string? studentScore;
    string valueEntered = "";
    int numericScore = 0;
    bool validNumber = false;

    Console.WriteLine($"Enter your Subject score. ");

    do
    {
        studentScore = Console.ReadLine();
        if (studentScore != null)
        {
            valueEntered = studentScore;
        }

        validNumber = int.TryParse(valueEntered, out numericScore);

        if (validNumber == true)
        {
            if (numericScore <= -1 || numericScore >= 101)
            {
                validNumber = false;
                Console.WriteLine($"You entered {numericScore}. Please enter a number between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
        }
    } while (validNumber1 == false);

}