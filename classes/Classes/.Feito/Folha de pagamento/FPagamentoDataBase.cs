using Catiotro_s.classes.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Cliente
{
   public class FPagamentoDataBase
    {
        public int Salvar (FPamentoDTO folha)
        {

            string script = @"INSERT INTO tb_folha_de_pagamento(ds_horas_extras,
                                                                id_funcionario
                                                                int_faltas,
                                                                vl_salario_bruto,
                                                                vl_imposto_e_renda,
                                                                vl_ftgs,
                                                                vl_vale_transporte,
                                                                id_funcionario,
                                                                vl_salario_liq,
                                                                id_inss,
                                                                id_sal_familia)
                                                         VALUES (@ds_horas_extras,
                                                                @int_faltas,
                                                                @vl_salario_bruto,
                                                                @vl_imposto_e_renda,
                                                                @vl_ftgs,
                                                                @vl_vale_transporte,
                                                                @id_funcionario,
                                                                @vl_salario_liq,
                                                                @id_inss,
                                                                @id_sal_familia)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_horas_extras", folha.HorasExtras));
            parms.Add(new MySqlParameter("id_funcionario", folha.IdFuncio));
            parms.Add(new MySqlParameter("int_faltas", folha.Faltas));
            parms.Add(new MySqlParameter("vl_salario_bruto", folha.SalBruto));
            parms.Add(new MySqlParameter("vl_imposto_e_renda", folha.ImpostoRenda));
            parms.Add(new MySqlParameter("vl_ftgs", folha.Fgts));
            parms.Add(new MySqlParameter("vl_vale_transporte", folha.VLTars));
            parms.Add(new MySqlParameter("id_funcionario", folha.IdFuncio));
            parms.Add(new MySqlParameter("vl_salario_liq", folha.SalLiq));
            parms.Add(new MySqlParameter("id_inss", folha.Inss));
            parms.Add(new MySqlParameter("id_sal_familia", folha.SalFamilia));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }

        public void Alterar (FPamentoDTO folha)
        {

            string script = @"UPDATE tb_folha_de_pagamento SET(ds_horas_extras = @ds_horas_extras,
                                                               int_faltas = @int_faltas,
                                                               vl_salario_bruto = @vl_salario_bruto,
                                                               vl_imposto_e_renda = @vl_imposto_e_renda,
                                                               vl_ftgs = @vl_ftgs,
                                                               vl_vale_transporte = @vl_vale_transporte,
                                                               id_funcionario = @id_funcionario,
                                                               vl_salario_liq = @vl_salario_liq,
                                                               id_inss = @id_inss,
                                                               id_sal_familia  = @id_sal_familia 
                                                         WHERE id_folha_pag = @id_folha_pag";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_folha_pag", folha.Id));
            parms.Add(new MySqlParameter("ds_horas_extras", folha.HorasExtras));
            parms.Add(new MySqlParameter("int_faltas", folha.Faltas));
            parms.Add(new MySqlParameter("vl_salario_bruto", folha.SalBruto));
            parms.Add(new MySqlParameter("vl_imposto_e_renda", folha.ImpostoRenda));
            parms.Add(new MySqlParameter("vl_ftgs", folha.Fgts));
            parms.Add(new MySqlParameter("vl_vale_transporte", folha.VLTars));
            parms.Add(new MySqlParameter("id_funcionario", folha.IdFuncio));
            parms.Add(new MySqlParameter("vl_salario_liq", folha.SalLiq));
            parms.Add(new MySqlParameter("id_inss", folha.Inss));
            parms.Add(new MySqlParameter("id_sal_familia", folha.SalFamilia));

            Database db = new Database();
            db.ExecuteInsertScriptWithPk(script, parms);

        }

        public void Remover (int IdFolha)
        {

            string script =
                "DELETE  FROM tb_folha_de_pagamento  WHERE id_folha_pag = @id_folha_pag";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_folha_pag", IdFolha));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public List<FPamentoDTO> Listar()
        {

            string script = @"SELECT * FROM tb_folha_de_pagamento";

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<FPamentoDTO> folhaL = new List<FPamentoDTO>();
            while (reader.Read())
            {

                FPamentoDTO folha = new FPamentoDTO();
                folha.Id = reader.GetInt32("id_folha_pag");
                folha.HorasExtras = reader.GetString("ds_horas_extras");
                folha.Faltas = reader.GetInt32("int_faltas");
                folha.SalBruto = reader.GetDecimal("vl_salario_bruto");
                folha.ImpostoRenda = reader.GetDecimal("vl_imposto_e_renda");
                folha.Fgts = reader.GetDecimal("vl_ftgs");
                folha.VLTars = reader.GetDecimal("vl_vale_transporte");     
                folha.IdFuncio = reader.GetInt32("id_funcionario");
                folha.SalLiq = reader.GetDecimal("vl_salario_liq");
                folha.Inss = reader.GetInt32("id_inss");
                folha.SalFamilia = reader.GetInt32("id_sal_familia");

                folhaL.Add(folha);
            }

            reader.Close();

            return folhaL;
                                
        }

        public List<FPamentoDTO> Consultar(string nome)
        {

            string script = @"SELECT * FROM tb_folha_de_pagamento WHERE id_funcionario LIKE @id_funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", nome + "%"));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<FPamentoDTO> folhaL = new List<FPamentoDTO>();
            while (reader.Read())
            {

                FPamentoDTO folha = new FPamentoDTO();
                folha.Id = reader.GetInt32("id_folha_pag");
                folha.HorasExtras = reader.GetString("ds_horas_extras");
                folha.Faltas = reader.GetInt32("int_faltas");
                folha.SalBruto = reader.GetDecimal("vl_salario_bruto");
                folha.ImpostoRenda = reader.GetDecimal("vl_imposto_e_renda");
                folha.Fgts = reader.GetDecimal("vl_ftgs");
                folha.VLTars = reader.GetDecimal("vl_vale_transporte");
                folha.IdFuncio = reader.GetInt32("id_funcionario");
                folha.SalLiq = reader.GetDecimal("vl_salario_liq");
                folha.Inss = reader.GetInt32("id_inss");
                folha.SalFamilia = reader.GetInt32("id_sal_familia");

                folhaL.Add(folha);
            }

            reader.Close();

            return folhaL;

        }




        //public List<ClienteDTO> Consultar(string nome)
        //{
        //    string script = @"SELECT * FROM tb_cliente WHERE nm_cliente LIKE @nm_cliente";

        //    List<MySqlParameter> parms = new List<MySqlParameter>();
        //    parms.Add(new MySqlParameter("nm_cliente", nome + "%"));

        //    Database db = new Database();
        //    MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

        //    List<ClienteDTO> cliente = new List<ClienteDTO>();
        //    while (reader.Read())
        //    {
        //        ClienteDTO DTO = new ClienteDTO();
        //        DTO.Id = reader.GetInt32("id_cliente");
        //        DTO.Nome = reader.GetString("nm_cliente");
        //        DTO.Telefone = reader.GetString("ds_telefone");
        //        DTO.Email = reader.GetString("ds_email");
        //        DTO.CPF = reader.GetString("ds_cpf");
        //        DTO.Cidade = reader.GetString("nm_cidade");
        //        DTO.Estado = reader.GetString("nm_estado");

        //        cliente.Add(DTO);
        //    }
        //    reader.Close();
        //    return cliente;
        //}


    }
}
