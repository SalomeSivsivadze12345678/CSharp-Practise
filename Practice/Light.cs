namespace Practice
{
    public class Light
    {
        public bool IsOn { get; private set; }
        public int Brightness { get; private set; } = 50;


        public void TurnOn()
        {
            IsOn = true;

        }

        public void TurnOff()
        {

            IsOn = false;
        }

        public void IncreaseBrightness()
        {
            if (IsOn)
            {
                if (Brightness + 10 <= 100)
                {
                    Brightness += 10;
                }
                else
                {
                    Console.WriteLine("Brightness is on maximum capacity");
                }
            }
            else
            {
                Console.WriteLine("Light is off");
            }
        }

        public void DecreaseBrightness()
        {
            if (IsOn)
            {

                if (Brightness - 10 >= 0)
                {
                    Brightness -= 10;
                }
                else
                {
                    Console.WriteLine("Brightness is on minimum capacity");

                }
            }
            else
            {
                Console.WriteLine("Light is off");
            }

        }
    }
}

