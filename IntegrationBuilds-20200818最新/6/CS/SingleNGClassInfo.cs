using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.CS
{
    public class SingleNGClassInfo
    {
        private string ngbarcode;

        public string NGbarcode
        {
            get { return ngbarcode; }
            set { ngbarcode = value; }
        }

        private string line;

        public string Line
        {
            get { return line; }
            set { line = value; }
        }

        private string update_time;

        public string Update_time
        {
            get { return update_time; }
            set { update_time = value; }
        }

        private List<string> ap_result;

        public List<string> Ap_result
        {
            get { return ap_result; }
            set { ap_result = value; }
        }

        private List<CellInfo> cellInfoList;

        public List<CellInfo> CellInfoList
        {
            get { return cellInfoList; }
            set { cellInfoList = value; }
        }

        
    }
}
