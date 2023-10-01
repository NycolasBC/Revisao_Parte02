using MegaSena.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Interfaces
{
    public interface IRegistroJogoService
    {
        List<RegistroJogoViewModel> ObterTodos();
        void AdicionarRegistro(NovoRegistroJogoViewModel registro);
    }
}
