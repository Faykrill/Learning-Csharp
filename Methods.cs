namespace Test
{

    class Methods : IMethods
    {
        private (int height, int width, bool HeightValid, bool WidthValid) GetAndValidateDimensions()
        {
            Console.Write("\n Введите height и width через Enter: \n");
            int height = int.Parse(Console.ReadLine() ?? "0");
            int width = int.Parse(Console.ReadLine() ?? "0");

            const int MinHeight = 280;
            const int MinWidth = 150;

            bool HeightValid = height >= MinHeight;
            bool WidthValid = width >= MinWidth;

            if (height < 0 || width < 0)
            {
                Console.WriteLine("Error: Negative values are not allowed.");
                return (height, width, HeightValid, WidthValid);
            }

            return (height, width, HeightValid, WidthValid);
        }
        
        public void ConditionIF()
        {
            Console.WriteLine("\n\"IF-ELSE\"");

            var (height, width, HeightValid, WidthValid) = GetAndValidateDimensions();

            if (height < 0 || width < 0) 
            return;

            if (HeightValid && WidthValid)
            {
                Console.WriteLine("It's Okey");
            }
            else if (HeightValid && !WidthValid)
            {
                Console.WriteLine("It's not Okey. Width < 150");
            }
            else if (!HeightValid && WidthValid)
            {
                Console.WriteLine("It's not Okey. Height < 280");
            }
            else
            {
                Console.WriteLine("It's very bad. Height and Width < 280 and 150");
            }
        }
        public void ConditionSwitch()
        {
            Console.WriteLine("\n\"SWITCH\"");

            var (height, width, HeightValid, WidthValid) = GetAndValidateDimensions();

            if (height < 0 || width < 0) 
            return;

            string message = (HeightValid, WidthValid) switch
            {
                (true, true) => "It's Okey",
                (true, false) => "It's not Okey. Width < 150",
                (false, true) => "It's not Okey. Height < 280",
                _ => "It's very bad. Height and Width < 280 and 150"
            };
            
            Console.WriteLine(message);

        }
    }
}
