using System;
using MySql.Data.MySqlClient;


namespace Conect
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Agenda agenda = new Agenda();

            while(true)
            {
                Console.WriteLine("\n_-_-_-_-_-_-_-_-_ Menu _-_-_-_-_-_-_-_-_");
                Console.WriteLine("\n1- Adicionar Novo Contato\n2- Listar Contatos\n3- Editar Contato\n4- Excluir Contato\n5- Sair");
                Console.WriteLine("O que deseja fazer: ");

                string op = Console.ReadLine();
               
                switch (op)
                {
                    case "1":
                        Console.Write("\nDigite o nome do contato:");
                        string nome = Console.ReadLine();

                        Console.Write("\nDigite o telefone:");
                        string telefone = Console.ReadLine();

                        Console.Write("\nDigite o email: ");
                        string email = Console.ReadLine();

                        Contato c1 = new Contato();
                        c1.SetNome(nome);
                        c1.SetTelefone(telefone);
                        c1.SetEmail(email);

                        agenda.AdicionarContato(c1);

                        break;

                    case "2":
                        agenda.ListarContatos();
                        break;
                    case "3":
                        Console.WriteLine("Digite o ID do contato que deseja editar: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o novo nome: ");
                        string novoNome = Console.ReadLine();

                        Console.WriteLine("Digite o novo telefone: ");
                        string novoTelefone = Console.ReadLine();

                        Console.WriteLine("Digite o novo e-mail: ");
                        string novoEmail = Console.ReadLine();

                        Contato c2 = new Contato();
                        c2.SetIdContato(id);
                        c2.SetNome(novoNome);
                        c2.SetTelefone(novoTelefone);
                        c2.SetEmail(novoEmail);

                        agenda.EditarContato(c2);

                        break;

                    case "4":
                        Console.WriteLine("Digite o ID do contato que deseja excluir: ");
                        int idRemovContato = int.Parse(Console.ReadLine());


                        agenda.RemoverContato(idRemovContato);
                        break;

                    case "5":
                        return;
                }


            }
        }
    }
}