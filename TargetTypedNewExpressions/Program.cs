using System;
using System.Collections.Generic;

Console.WriteLine("Beginning of code");

Dictionary<string, string> hash = new()
{
    { "a", "asf" }
};

Person person = new()
{ 
    FirstName = "RDE", 
    LastName = "Code"
};

person.DisplayFullName();