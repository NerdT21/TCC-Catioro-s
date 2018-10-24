using Catiotro_s.classes.Classes.AddConsultar.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Cliente
{
    public class ClienteBusiness
    {
        public int Salvar(ClienteDTO cliente)
        {
            ClienteDataBase DB = new ClienteDataBase();
            int id = DB.Salvar(cliente);
            return id;
        }

        public void Alterar(ClienteDTO cliente)
        {
            ClienteDataBase DB = new ClienteDataBase();
            DB.Alterar(cliente);
        }

        public void Remover(int idcliente)
        {
            ClienteDataBase DB = new ClienteDataBase();
            DB.Remover(idcliente);
        }

        public List<ClienteView> Listar()
        {
            ClienteDataBase DB = new ClienteDataBase();
            return DB.Listar();
        }

        public List<ClienteDTO> ListarPraCombo()
        {
            ClienteDataBase DB = new ClienteDataBase();
            return DB.ListarPraCombo();
        }

        public List<ClienteView> Consultar(string nome, string cpf)
        {
            ClienteDataBase DB = new ClienteDataBase();
            return DB.Consultar(nome, cpf);
        }
    }
}
