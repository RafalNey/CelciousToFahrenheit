public static class TemperatureConverter
{
    public static double CelciousToFahrenheit(string temperatureCelcious)
    {
        //convert argument for double for converstion
        double celcious = Double.Parse(temperatureCelcious);

        //convert Celcoius to fahrenheit
        double fahrenheit = (celcious * 9 / 5) + 32;

        return fahrenheit;
    }

    public static double FahrenheitToCelcious(string temperatureFahrenheit)
    {
        //convert argument for double for conversion
        double fahrenheit = Double.Parse(temperatureFahrenheit);

        //convert Fahrenheit to Celcious
        double celcious = (fahrenheit - 32) * 5 / 9;

        return celcious;
    }
}