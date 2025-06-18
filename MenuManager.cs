namespace Test
{
    class MenuManager : IMenuManager
    {
        private readonly IMethods _methods;
        private readonly Dictionary<string, (string Name, Action Command)> _menuItems;

        public MenuManager()
        {
            _methods = new Methods();

            _menuItems = new()
            {
                ["1"] = ("IF-ELSE", () => _methods.ConditionIF()),
                ["if-else"] = ("IF-ELSE", () => _methods.ConditionIF()),
                ["2"] = ("SWITCH", () => _methods.ConditionSwitch()),
                ["switch"] = ("SWITCH", () => _methods.ConditionSwitch())
            };
        }

        public void ShowMainMenu()
        {
            Console.WriteLine("Main Menu:");

            // Выводим все пункты с цифрами
            int i = 1;
            foreach (var key in _menuItems.Keys.Where(k => k.Length == 1)) // Берём только цифры
            {
                Console.WriteLine($"{i++}. {_menuItems[key].Name}");
            }

            Console.WriteLine($"{i}. Exit");
            Console.Write("\nSelect item: ");
        }

        public void HandleUserChoice()
        {
            while (true)
            {
                Console.Clear();
                ShowMainMenu();
                
                string input = Console.ReadLine()?.ToLower() ?? "";
                
                if (input == "exit" || input == "3") break;
                
                if (_menuItems.TryGetValue(input, out var item))
                {
                    item.Command(); // Выполняем команду
                    ReturnToMenu();
                }
                else
                {
                    Console.WriteLine("Ошибка: неверный пункт!");
                    Console.ReadKey();
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
