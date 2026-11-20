using Humanizer;

Console.WriteLine("Hello, World!");
Console.WriteLine(DateTime.UtcNow.AddHours(-3).Humanize());
Console.WriteLine(1234.ToWords());
