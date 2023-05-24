using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEmpresaReserva.Model
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        private static int proximoId = 1;

        public static int GerarId()
        {
            int novoId = proximoId;
            proximoId++;
            return novoId;
        }
    }
}
