namespace Test
{

    class Methods : IMethods
    {
        InputHandler _input = new InputHandler();
        private (int height, int width, bool HeightValid, bool WidthValid, bool r_height, bool r_width) GetAndValidateDimensions()
        {
            Console.Write("\n Введите height и width через Enter: \n");

            bool r_height = int.TryParse(Console.ReadLine(), out int height);
            bool r_width = int.TryParse(Console.ReadLine(), out int width);

            const int MinHeight = 280;
            const int MinWidth = 150;

            bool HeightValid = height >= MinHeight;
            bool WidthValid = width >= MinWidth;

            if (height < 0 || width < 0)
            {
                Console.WriteLine("Error: Negative values are not allowed.");
                return (height, width, HeightValid, WidthValid, r_height, r_width);
            }
            else if (!r_height || !r_width)
            {
                Console.WriteLine("Error: Incorrect input");
                return (height, width, HeightValid, WidthValid, r_height, r_width);
            }

            return (height, width, HeightValid, WidthValid, r_height, r_width);
        }

        public void ConditionIF()
        {
            Console.WriteLine("\n\"IF-ELSE\"");

            var (height, width, HeightValid, WidthValid, r_height, r_width) = GetAndValidateDimensions();

            if (height < 0 || width < 0 || !r_height || !r_width)
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

            var (height, width, HeightValid, WidthValid, r_height, r_width) = GetAndValidateDimensions();

            if (height < 0 || width < 0 || !r_height || !r_width)
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

        public void OneArray()
        {

            Console.WriteLine("Введите размер списка: ");

            bool b_quantity = int.TryParse(Console.ReadLine(), out int quantity);
            if (!_input.Valid(b_quantity)) return;

            List<int> list = _input.InputHandlerListInt("Введите: ", quantity);

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
