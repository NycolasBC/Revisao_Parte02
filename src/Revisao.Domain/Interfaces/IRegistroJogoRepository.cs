using MegaSena.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Interfaces
{
    public interface IRegistroJogoRepository
    {
        List<RegistroJogo> ObterTodos();
        void AdicionarRegistro(RegistroJogo registro);
    }
}
