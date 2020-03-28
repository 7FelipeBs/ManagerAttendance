using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlAttendance.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ControlAttendance.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ControlAttendanceContext(
                serviceProvider.GetRequiredService
                <DbContextOptions<ControlAttendanceContext>>()))
            {
                if (context.Employee.Any())
                {
                    return;
                }

                context.Employee.AddRange(
                    new Employee
                    {
                        Id = 0,
                        Name = "Felipe Bruno Silva",
                        Anniversary = DateTime.Parse("1989-2-12"),
                        Email = "felipe@gmail.com",
                        CPF = "140.786.139-66",
                        NumberPhone = 992213132,
                        Salary = 1039,
                        AnyAddress = "Avenida babel",
                        NumberAdress = 69,
                        City = "Uberlândia",
                        District = "Canaã"
                    });

                context.SaveChanges();
            }
        }
    }
}
