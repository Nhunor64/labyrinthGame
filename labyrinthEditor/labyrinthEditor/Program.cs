﻿using System.Resources;
using System.Globalization;
using labyrinthEditor.Functions;
using System.Text;

namespace labyrinthEditor;
class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        Map map = new Map();
        CursorMovement cursorMovement = new CursorMovement();
        Console.OutputEncoding = Encoding.UTF8;
        
        MainMenu()
    }

}
