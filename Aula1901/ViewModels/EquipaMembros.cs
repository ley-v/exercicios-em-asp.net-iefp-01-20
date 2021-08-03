using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Aula1901.Models;

namespace Aula1901.ViewModels
{
    public class EquipaMembros
    {
        //Novo modelo, guardado na pasta ViewModels
        public IEnumerable<Equipa> Equipas { get; set; }
        public IEnumerable<Membro> Membros { get; set; }




    }
}