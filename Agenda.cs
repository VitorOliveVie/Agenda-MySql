using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Engines;

namespace Conect
{
    public class Agenda : IAgenda
    {
        private List<Contato> contatos = new List<Contato>();
        private string connStr = "server=localhost;user=root;database=Unip;port=3306;password=1234;";

        public void AdicionarContato(Contato c1)
        {
            MySqlConnection conn = new MySqlConnection(this.connStr);

            try
            {
                conn.Open();
                string sqlInsert = $"INSERT INTO unip.contato (nome, telefone, email) VALUES ('{c1.GetNome()}', '{c1.GetTelefone()}', '{c1.GetEmail()}')";
                MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, conn);
                cmdInsert.ExecuteNonQuery();
                Console.WriteLine("\nRegistro inserido com sucesso!");
                conn.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar contato: {ex.Message}");
            }


        }
        public void EditarContato(Contato c1)
        {
            MySqlConnection conn = new MySqlConnection (this.connStr);

            try
            {
                conn.Open();
                string sqlUpdate = $"UPDATE unip.contato set nome= '{c1.GetNome()}', telefone= '{c1.GetTelefone()}', email= '{c1.GetEmail()}' where idcontato= '{c1.GetIdContato()}'";
                MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn);
                cmdUpdate.ExecuteNonQuery();
                Console.WriteLine("\nContato atualizado com sucesso!");
                conn.Close();
            }catch (Exception ex)
            {
                Console.WriteLine($"Erro ao editar contato: {ex.Message}");
            }

        }
        public void RemoverContato(int idContato)
        {

            MySqlConnection conn = new MySqlConnection(connStr);


            try
            {
                conn.Open();
                    string sqlDelete = $"DELETE FROM unip.contato WHERE idcontato= '{idContato}'";
                    MySqlCommand cmdDelete = new MySqlCommand(sqlDelete, conn);
                    cmdDelete.ExecuteNonQuery();
                    Console.WriteLine("\nContato Excluido com sucesso!");
                conn.Close();
            }catch(Exception ex)
            {
                Console.WriteLine($"Erro ao deletar contato: {ex.Message}");
            }
            

        }

        public void ListarContatos()
        {
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string sqlSelect = $"SELECT * from unip.contato";
                MySqlCommand cmdSelect = new MySqlCommand(sqlSelect, conn);
                MySqlDataReader reader = cmdSelect.ExecuteReader();

                while(reader.Read())
                {
                    Console.WriteLine($"\nID: {reader.GetInt32(0)} \nNome: {reader.GetString(1)} \nTelefone: {reader.GetString(2)} \nE-mail: {reader.GetString(3)}");
                }

                reader.Close();
                conn.Close();

            }catch (Exception ex)
            {
                Console.WriteLine($"Erro ao selecionar contatos: {ex.Message}");
            }

        }
    }
}
