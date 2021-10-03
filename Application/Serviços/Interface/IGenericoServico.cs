using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Serviços.Interface
{
    public interface IGenericoServico<S>
    {
        S Cadastro(S model);
        void Atualizar(int id, S model);
        void Deletar(int id);
        S ObterUm(int id);
        List<S> ObterTodos();


    }
}
