using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BartenderApplication.Contexts;

namespace BartenderApplication.Models
{
    public class EFMenuRepository : IMenuRepository
    {
        private MenuContext context;
        public EFMenuRepository(MenuContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<MenuItem> MenuItems => context.MenuItem;

    }
}
