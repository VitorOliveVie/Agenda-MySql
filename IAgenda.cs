using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conect
{
    public interface IAgenda
    {
        void AdicionarContato(Contato c1);
        void RemoverContato(int idContato);
        void ListarContatos();
        void EditarContato(Contato c1);
    }
}
