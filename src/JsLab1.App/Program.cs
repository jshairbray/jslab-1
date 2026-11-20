using Humanizer;
using JsLab1.Greetings;

Console.WriteLine(Greeter.Hello("Jonathan"));
Console.WriteLine(DateTime.UtcNow.AddHours(-3).Humanize());
Console.WriteLine(1234.ToWords());
