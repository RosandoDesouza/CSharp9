using static System.Console;
using System.Threading.Tasks;

if(args.Length > 1)
{
    WriteLine($"Args present, first argument: {args[0]}");
}
else
{
    WriteLine("No args present");
}

WriteLine("Hello World 2!");

WriteLine("Wait to 2 secs");

await Task.Delay(2000);

WriteLine("Wait Completed");

Person person = new Person();
await person.Greet();