using ExercicioEmpresaReserva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEmpresaReserva.Service
{
    public class ProdutoService
    {
        public ProdutoService()
        {

        }

        public string CadastrarProduto(string nome, string descricao)
        {
            var produto = new ProdutoModel
            {
                Id = ProdutoModel.GerarId(),
                Nome = nome,
                Descricao = descricao
            };

            return string.Format("Produto criado com o Id = {0}", produto.Id);
        }

        public void AlterarValor(int produtoId, double valor)
        {
            var valorProduto = new PrecoModel
            {
                ProdutoId = produtoId,
                Preco = valor,
                Data = DateTime.Now.ToString()
            };
        }
    }
}
