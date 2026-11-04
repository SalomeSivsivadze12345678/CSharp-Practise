namespace Practice
{
    public class TemperatureConverter
    {
        public decimal Celcius { get; private set; }

        public TemperatureConverter(decimal celcius)
        {
            if (celcius < -273.15m)
            {
                Console.WriteLine("Write correct number");
            }
            else
            {
                Celcius = celcius;
            }

        }

        public decimal ConvertToFarenheit()
        {
            return Celcius * 1.8m + 32;
        }

        public decimal ConvertToKelvin()
        {
            return Celcius + 273.15m;
        }
    }
}

