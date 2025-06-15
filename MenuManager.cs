namespace Test
{
    class MenuManager : IMenuManager
    {
        IMethods _methods = new Methods();
        public void ShowMainMenu()
        {
            Console.WriteLine("Main Menu: ");
            Console.WriteLine("1. \"IF-ELSE\"");
            Console.WriteLine("2. \"SWITCH\"");
            Console.WriteLine("3. Exit");
            Console.Write("\nSelect item: ");
        }
        public void HandleUserChoice()
        {
            while (true)
            {
                Console.Clear();
                ShowMainMenu();
                string input = Console.ReadLine() ?? "3";

                switch (input)
                {
                    case "1" or "IF-ELSE":
                        _methods.ConditionIF();
                        ReturnToMenu();
                        break;
                    case "2" or "SWITCH" or "switch":
                        _methods.ConditionSwitch();
                        ReturnToMenu();
                        break;
                    case "3" or "end" or "break" or "exit":
                        Console.WriteLine("Exit....");
                        return;
                    default:
                        Console.WriteLine("Ошибка: введите 1, 2 или 3");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void ReturnToMenu()
        {
            Console.WriteLine("\n Нажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}
