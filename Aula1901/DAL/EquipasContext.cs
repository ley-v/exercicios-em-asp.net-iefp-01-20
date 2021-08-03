using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Aula1901.Models;

namespace Aula1901.DAL
{
    //esse é um modelo da base de dados
    public class EquipasContext : DbContext
    {
        public DbSet<Equipa> TEquipa { get; set; }

        public DbSet<Membro> TMembro { get; set; }
    }
}