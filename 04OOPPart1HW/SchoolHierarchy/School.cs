using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolHierarchy
{
    public class School
    {
        public List<SchoolClass> SchoolClasses { get; set; }

        public School()
        {
            this.SchoolClasses = new List<SchoolClass>();
        }
    }
}
