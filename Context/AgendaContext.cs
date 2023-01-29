using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloApi.Models;

namespace ModuloApi.Context
{
    public class AgendaContext : DbContext
    {
        /* Construtor do c# é o nome da class */
        public AgendaContext(DbContextOptions<AgendaContext> options): base(options) { 

        }

        public DbSet<Contato> Contatos{ get; set; }
    }
}