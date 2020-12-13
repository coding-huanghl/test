using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6
{
    public class SingleClassNG
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private bool updateDone;
        public bool UpdateDone
        {
            get { return updateDone; }
            set { updateDone = value; }
        }

        private string[] info = new string[30];
        public string[] Info
        {
            get { return info; }
            set { info = value; }
        }

        private string[] picPath = new string[30];
        public string[] PicPath
        {
            get { return picPath; }
            set { picPath = value; }
        }
       
    }
}
