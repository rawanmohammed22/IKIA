using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKIA.DAL.Models.Departments
{
    public class Department:ModelBase

    {
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;


        public string? Discription { get; set; }


        public DateOnly CreationDate { get; set; }

    }
}
