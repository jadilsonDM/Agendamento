using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IGenericoRepository<T>
    {
        T Cadastro(T model);
        void Atualizar(int id, T model);
        void Deletar(int id);
        T ObterUm(int id);
        List<T> ObterTodos();
    }
}
