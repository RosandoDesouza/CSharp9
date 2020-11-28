using System;
using System.Collections.Generic;

Console.WriteLine("Beginning of code");

Dictionary<string, string> hash = new()
{
    { "a", "asdf" }
};

Person p = new() 
{
    FirstName = "RDE",
    LastName = "Code"
};

p.DisplayFullName();
