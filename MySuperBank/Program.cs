using System.Security.Principal;

using MySuperBank;

Console.WriteLine("Welcome to the TechBruv Finance System");

Console.WriteLine("As you can see we only accept new users, So Register below.");


// New Registration

Registration registration = new Registration();


Console.WriteLine("Kindly enter your name");
registration.Name = Console.ReadLine();

Console.WriteLine("Kindly enter your Email");
registration.Email = Console.ReadLine();

Console.WriteLine("Kindly enter your Phone Number");
registration.PhoneNumber = Console.ReadLine();

Console.Clear();



// creation of new account.

string NewUserName = registration.Name;

var account = new BankAccount(NewUserName, 0.002m);

Console.WriteLine($"Account {account.AccNumber} was created for {account.Name} with {account.Balance:C} initial balance.");


DepositTester();

WithdrawalTester();

Console.WriteLine("");

Console.WriteLine("This is your account history");

Console.WriteLine(account.GetAccountHistory());




// Method to Test for Deposit
void DepositTester()

{
    Console.WriteLine("Do you want to make a deposit? Please enter Y or N: ");

    string response = Console.ReadLine();

    if (response == "Y" || response == "y")
    {
        DepositMaker();
    }


else if (response == "N" || response == "n")
    {
        Console.WriteLine("Would like to make a Withdrawal then? Please enter Y or N: ");
        response = Console.ReadLine();
        if (response == "Y" || response == "y")
        {
            WithdrawalMaker();
        }
        else
        Console.WriteLine($"Hi {account.Name} this your account balance: {account.Balance:C}.");
    }

else
     {
          Console.WriteLine("Invalid response. You're out");
          Console.WriteLine($"Hi {account.Name} this your account balance: {account.Balance:C}.");
     } 

}

// Method to Test and ask for Withdrawal.
void WithdrawalTester()

{
    Console.WriteLine("Do you want to make a Withdrawal? Please enter Y or N: ");

    string response = Console.ReadLine();

    if (response == "Y" || response == "y")
    {
        WithdrawalMaker();
    }


    else if (response == "N" || response == "n")
    {
        Console.WriteLine("Would like to make a Deposit then? Please enter Y or N: ");
        response = Console.ReadLine();
        if (response == "Y" || response == "y")
        {
            DepositMaker();
        }
        else
            Console.WriteLine($"Hi {account.Name} this your account balance: {account.Balance:C}.");
    }

    else
    {
        Console.WriteLine("Invalid response. You're out");
        Console.WriteLine($"Hi {account.Name} this your account balance: {account.Balance:C}.");
    }

}

// Method to make Deposit
void DepositMaker()
{

    // account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
    // Console.WriteLine(account.Balance);

    Console.WriteLine("Please enter deposit amount: ");
    decimal depositAmount = decimal.Parse(Console.ReadLine());

    //  Console.WriteLine("Please enter deposit date (MM/DD/YYYY): "); 
    //  DateTime depositDate = DateTime.Parse(Console.ReadLine()); 

    Console.WriteLine("Please enter deposit note: ");
    string depositNote = Console.ReadLine();

    account.MakeDeposit(depositAmount, DateTime.Now, depositNote);
    Console.WriteLine($"Hi {account.Name}, {depositAmount:C} was deposited into your account and your new balance is {account.Balance:C}\n");
}


// Method to make Withdrawal.
void WithdrawalMaker()
{
    //account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
    //Console.WriteLine(account.Balance);

    Console.WriteLine("Please enter withdrawal amount: ");
    decimal withdrawalAmount = decimal.Parse(Console.ReadLine());

    //  Console.WriteLine("Please enter deposit date (MM/DD/YYYY): "); 
    //  DateTime depositDate = DateTime.Parse(Console.ReadLine()); 

    Console.WriteLine("Please enter Withdrawal note: ");
    string withdrawalNote = Console.ReadLine();


    account.MakeWithdrawal(withdrawalAmount, DateTime.Now, withdrawalNote);
    Console.WriteLine($"Hi {account.Name}, {withdrawalAmount:C} was withdrawn from your account and your new balance is {account.Balance:C}\n");
}






