using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.CS
{
    public class CellInfo
    {
        private string cell_index;

        public string Cell_index
        {
            get { return cell_index; }
            set { cell_index = value; }
        }

        private List<string> info;

        public List<string> Info
        {
            get { return info; }
            set { info = value; }
        }
    }
}
