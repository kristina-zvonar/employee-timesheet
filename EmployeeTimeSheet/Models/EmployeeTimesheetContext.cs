using MySql.Data.Entity;
using System.Data.Entity;
using EmployeeTimesheetBL.DAL;

namespace EmployeeTimeSheet
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class EmployeeTimesheetContext : DbContext
    {
        public DbSet<Employee> Employees
        {
            get;
            set;
        }
        public EmployeeTimesheetContext()
            //Reference the name of your connection string ( WebAppCon )  
            : base("EmployeeTimesheetConnection") { }
    }
}