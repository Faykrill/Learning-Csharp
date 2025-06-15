using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Test
{
    class Testing
    {
        IMenuManager _menu = new MenuManager(); 
        void Main(string[] args)
        {
            _menu.HandleUserChoice();
        }

    }   
}
