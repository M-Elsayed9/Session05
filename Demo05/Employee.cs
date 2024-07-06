using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public Department Department { get; set; }
      
    }

    class Department
    {
        public int Code { get; set; }
        public string Name { get; set; }

    }
}
