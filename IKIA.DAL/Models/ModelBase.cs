using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKIA.DAL.Models
{
    public class ModelBase


    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }

        public int CreatedBy { get; set; }
        public int LastModificationBy { get; set; }

        public DateTime LastModificatioOn{ get; set; }


        public bool IsDeleted { get; set; }


    }
}
