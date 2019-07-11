using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext (DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Library.Models.TestDetails> TestDetails { get; set; }
        public DbSet<Library.Models.TestType> TestType { get; set; }
        public DbSet<Library.Models.AthletesDetails> AthletesDetails { get; set; }
    }
}
