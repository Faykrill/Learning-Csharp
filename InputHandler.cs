namespace Test
{
    class InputHandler
    {
        public bool Valid(bool b_value)
        {
            if (!b_value)
            {
                Console.WriteLine("Error: Incorrect Input");
                return false;
            }
            return true;
        }
        public int InputHandlerOneInt(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                if (int.TryParse(Console.ReadLine(), out int value))
                    return value;

                Console.WriteLine("Error: Incorrect Input");
            }
        }

        public List<int> InputHandlerListInt(string prompt, int quantity)
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? " ";
            var input2 = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                .Where(s => int.TryParse(s, out _))
                                .Select(int.Parse)
                                .ToList();

            if (input2.Count > quantity)
            {
                return input2.GetRange(0, Math.Min(quantity, input2.Count));
            }
            return input2;
        }
    }
}
