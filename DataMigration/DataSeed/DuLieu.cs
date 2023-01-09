using Data.Migration.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Data.Migration.DataSeed
{
    public static class DuLieu
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserBeforeLoding>().HasData(
                new UserBeforeLoding() { UserBeforeLodingId = 1, EmployeeNo = "V0515311", EmployeeName = "Hà", Notes = "test@gmail.com", CreateTime = DateTime.Now,Password="1234567Aa" ,Id= 1 }
                );
        }
    }
}
