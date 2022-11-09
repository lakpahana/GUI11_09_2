using System;
using System.Collections.Generic;
using System.Text;

namespace GUI11_09_2
{
    public class MenuItem
    {
        public string Title { get; set; }
        public bool IsSelected { get; set; }
        public MenuItem(string title)
        {
            Title = title;

        }
}
}
