using ModeloVistaControlador.Controllers;
using System;
using System.Collections.Generic;

namespace ModeloVistaControlador
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuController menuController = new MenuController();
            menuController.ManageMenu();
        }
    }
}
