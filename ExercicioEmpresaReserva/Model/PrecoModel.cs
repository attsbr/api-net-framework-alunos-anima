﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEmpresaReserva.Model
{
    public class PrecoModel
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public double Preco { get; set; }
        public string Data { get; set; }
    }
}
