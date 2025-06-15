using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Test
{
    class Program
    { 
        static void Main(string[] args)
        {
            IMenuManager _menu = new MenuManager();
            _menu.HandleUserChoice();
        }

    }   
}
