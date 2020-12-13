using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace _6.CS
{
    public class textObject
    {
        private string key;
        public string Key
        {
            get { return key; }
            set { key = value; }
        }
        private int size;
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        private FontStyle fontstyle;

        public FontStyle Fontstyle
        {
            get { return fontstyle; }
            set { fontstyle = value; }
        }
    }
}
