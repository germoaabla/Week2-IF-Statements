Console.WriteLine("Enter your lastname:");
string lastname = Console.ReadLine();

Console.WriteLine("Enter your gender (f/m/n):");
char userGender = char.Parse(Console.ReadLine());

string greeting;

if (userGender == 'f')
{
    greeting = "Ms.";
}
else if (userGender == 'm')
{
    greeting = "Mr.";
}
else
{
    greeting = "";
}


Console.WriteLine($"Hello, {greeting} {lastname}!");

Console.WriteLine("Enter your year of birth:");

int usersYOB = Int32.Parse(Console.ReadLine());

int currentYear = DateTime.Now.Year;

//Console.WriteLine($"Current year: {currentYear}");

int userAge = currentYear - usersYOB;

//int userAge = Int32.Parse(Console.ReadLine());

if (userAge >= 13)
{
    Console.WriteLine($"You are {userAge} - old enough to have an account");
}
else
{
    Console.WriteLine($"You are {userAge} - too young to have an account");
}
