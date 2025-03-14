using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKIA.DAL.Models.Departments;
using Microsoft.EntityFrameworkCore;






namespace IKIA.DAL.Prsistance.Data
{
    public class ApplicationDbContext:DbContext
    {
        #region       DbSet

        public DbSet<Department> Departmenr { get; set; }









        #endregion

    }
}
