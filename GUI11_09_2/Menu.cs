using System;
using System.Collections.Generic;
using System.Text;

namespace GUI11_09_2
{
    public class Menu
    {
        List<int> list = new List<int>();
        List<MenuItem> menu = new List<MenuItem>();

        public Menu()
        {
            MenuItem item1 = new MenuItem("File");
            MenuItem item2 = new MenuItem("Edit");
            MenuItem item3 = new MenuItem("Close");
            menu.Add(item1);
            menu.Add(item2);
            menu.Add(item3);
            
        }

        public void Create()
        {
        
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            int cursorPos = 0;
            foreach(MenuItem m in menu)
            {
                Console.SetCursorPosition(8, 3+ cursorPos++);
                Console.WriteLine(m.Title);
            }

        }
    }
}
