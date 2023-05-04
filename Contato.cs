using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conect
{
    public class Contato
    {
        private int idContato;
        private string nome;
        private string telefone;
        private string email;

        public int GetIdContato()
        {
            return (int)idContato;
        }
        public string GetNome()
        {
            return nome;
        }
        public string GetTelefone()
        {
            return telefone;
        }
        public string GetEmail()
        {
            return email;
        }
        public void SetIdContato(int id)
        {
            this.idContato = id;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public void SetTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }

    }
}
