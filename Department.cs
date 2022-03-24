using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Day3_2DArray
{
    public class Department
    {
        private int id;
        private string dname;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Dname
        { 
            get { return dname; } 
            set { dname = value; } 
        }    
    }
}
