using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BartenderApplication.Models;

namespace BartenderApplication.Contexts
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) :
            base(options)
        { }
        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}
