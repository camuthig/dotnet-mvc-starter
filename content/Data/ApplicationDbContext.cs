using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MvcStarter.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
    }
}