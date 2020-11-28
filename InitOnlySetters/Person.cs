using static System.Console;

public class Person 
{
    public string FirstName { get; init; }

    public string LastName { get; init; }
    
    public void DisplayFullName()
    {
        WriteLine($"{FirstName} {LastName}");
    }
}