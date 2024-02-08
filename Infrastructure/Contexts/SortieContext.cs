﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class SortieContext : DbContext
    {
        public DbSet<Sortie> Sortie { get; set; }
    }
}
