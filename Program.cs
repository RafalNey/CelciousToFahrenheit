
Console.WriteLine("Please select the conventor direction");
Console.WriteLine("1. From Celcius to Fahrenheit");
Console.WriteLine("2. From Fahrenheit to Celcius");
Console.WriteLine("3. Exit");
Console.WriteLine("");

string? selection = Console.ReadLine();
double F, C = 0;

while (selection != "3")
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

        case "3":
            break;

        default:
            Console.WriteLine("Please, select a convertor");
            break;
    }
}
