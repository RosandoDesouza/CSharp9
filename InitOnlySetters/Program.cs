using static System.Console;

WriteLine("Hello World!");

Person person = new Person()
{
    FirstName = "John",
    LastName = "Doe"
};
person.DisplayFullName();

Derived d = new Derived()
{
    Value = true
};