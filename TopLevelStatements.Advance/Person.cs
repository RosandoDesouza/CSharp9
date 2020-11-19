using System.Threading.Tasks;
using static System.Console;

public class Person 
{
    public async Task Greet()
    {
        await Task.Delay(1000);
        WriteLine("Hi");
    }
}