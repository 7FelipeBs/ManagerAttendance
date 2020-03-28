using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ControlAttendance.Models;

namespace ControlAttendance.Data
{
    public class ControlAttendanceContext : DbContext
    {
        public ControlAttendanceContext (DbContextOptions<ControlAttendanceContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
}
