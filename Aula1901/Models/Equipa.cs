using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula1901.Models
{
    public class Equipa
    {
        public int Id { get; set; }
        public string NomeEquipa { get; set; }

        public virtual ICollection<Membro> Membros {get; set;}
    }
}