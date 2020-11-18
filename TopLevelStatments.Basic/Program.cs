using System;

Console.WriteLine("Hello World!");

Person jack = new Person();
jack.FirstName = "Jack";
jack.LastName = "Doe";

Console.WriteLine(jack.DisplayFullName());

class Person 
{
    public string FirstName { get; set; }  

    public string LastName { get; set; }

    public string DisplayFullName()
    {
        return $"{this.FirstName} {this.LastName}";
    }
}