
Console.WriteLine("Please select the direction of conversion:");
Console.WriteLine("1. From Celcious to Fahrenheit");
Console.WriteLine("2. From Fahrenheit to Celcious");
Console.WriteLine("3. Exit");
Console.WriteLine("================================================================");

string? selection = Console.ReadLine();
double F, C = 0;

do
{
    switch (selection)
    {
        case "1":
            Console.WriteLine("Please, enter the Celcious temperature:");
            F = TemperatureConverter.CelciousToFahrenheit(Console.ReadLine() ?? "0");
            Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
            break;

        case "2":
            Console.WriteLine("Please, enter the Fahrenheit temperature:");
            C = TemperatureConverter.FahrenheitToCelcious(Console.ReadLine() ?? "0");
            Console.WriteLine("Temperature in Celcious: {0:F2}", C);
            break;

        default:
            Console.WriteLine("Please, select a direction of convesion: 1) C => F, 2) F => C, eventualy 3) exit");
            break;
    }
    selection = Console.ReadLine();
}
while (selection != "3");
