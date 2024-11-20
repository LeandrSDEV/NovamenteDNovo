﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NovamenteDenovo.Models;

namespace NovamenteDenovo.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext (DbContextOptions<BancoContext> options)
            : base(options)
        {
        }

        public DbSet<NovamenteDenovo.Models.Department> Department { get; set; } = default!;
    }
}
