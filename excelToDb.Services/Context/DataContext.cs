using excelToDb.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excelToDb.Data.Context
{
    public class DataContext: DbContext
    {
        public DbSet<Sample> Samples { get; set; }
        public DataContext() : base("Conn")
        {
              
        }
    }
}
