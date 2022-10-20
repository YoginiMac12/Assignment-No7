using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No7
{
    public class Department
    {
        private int deptid;
        private string deptname;
        private string location;

        public int Deptid
        {
            get { return deptid; }
            set { deptid = value; }
        }

        public string Deptname
        {
            get { return deptname; }
            set { deptname = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public override string ToString()
        {
            return $" Department Deptid {deptid} Deptname {deptname} Location {location}";
        }
    }
}

