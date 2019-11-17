﻿using Core_RBS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nota2.ModelsView
{
    public class RelatorioViewModel
    {
        public string AutoAvaliacaoChecked { get; set; }
        public ICollection<Voto> Votos { get; set; }
        public ICollection<Campanha> Campanhas { get; set; }
        public double MediaVotos { get; set; }
    }
}
