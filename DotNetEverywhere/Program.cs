
using SharedLibrary;

Console.WriteLine("I can run everywhere!");

Console.WriteLine($"OS version is: {Environment.OSVersion}");

if (OperatingSystem.IsMacOS())
{
    Console.WriteLine("I am macOS.");
}
else if (OperatingSystem.IsWindowsVersionAtLeast(major: 10))
{
    Console.WriteLine("I am Windows 10 or 11.");
}
else
{
    Console.WriteLine("I am same other mysterious OS.");
}
var number = -10;
if (number.IsValidNumber())
{
    Console.WriteLine("I got it with NuGet {0}", number);
}
else
{
    Console.WriteLine("Number negative {0}", number);
}

Console.WriteLine("Press ENTER to stop me.");
Console.ReadLine();