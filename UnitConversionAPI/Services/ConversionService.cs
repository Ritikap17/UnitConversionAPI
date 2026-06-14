namespace UnitConversionAPI.Services
{
    public class ConversionService
    {
        // Length Conversion
        public double ConvertLength(string from, string to, double value)
        {
            from = from.ToLowerInvariant();
            to = to.ToLowerInvariant();

            if (from == "meter" && to == "feet")
                return value * 3.28084;

            if (from == "feet" && to == "meter")
                return value / 3.28084;

            throw new Exception("Invalid length conversion");
        }

        // Temperature Conversion
        public double ConvertTemperature(string from, string to, double value)
        {
            from = from.ToLowerInvariant();
            to = to.ToLowerInvariant();

            if (from == "celsius" && to == "fahrenheit")
                return (value * 9 / 5) + 32;

            if (from == "fahrenheit" && to == "celsius")
                return (value - 32) * 5 / 9;

            throw new Exception("Invalid temperature conversion");
        }

        // Weight Conversion
        public double ConvertWeight(string from, string to, double value)
        {
            from = from.ToLowerInvariant();
            to = to.ToLowerInvariant();

            if (from == "kilogram" && to == "pound")
                return value * 2.20462;

            if (from == "pound" && to == "kilogram")
                return value / 2.20462;

            throw new Exception("Invalid weight conversion");
        }
    }
}