using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class BaseContext : DbContext
    {
        public DbSet<Camiseta> Camiseta { get; set; }
        public BaseContext() : base(@"Data Source=192.168.0.114;Initial Catalog=Roupa;Persist Security Info=True;User ID=Roupas;Password=roupas123")
        {

        }
    }
}
