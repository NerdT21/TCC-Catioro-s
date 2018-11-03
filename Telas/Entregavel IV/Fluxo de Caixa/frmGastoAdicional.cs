using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catiotro_s.classes.Classes.Gastos_Adicionais;
using Catiotro_s.CustomException.TelasException;

namespace Catiotro_s.Telas.Entregavel_IV.Fluxo_de_Caixa
{
    public partial class frmGastoAdicional : UserControl
    {
        public frmGastoAdicional()
        {
            InitializeComponent();
            DataParaHoje();
        }

        void DataParaHoje()
        {
            DateTime hoje = DateTime.Now;
            int dia = hoje.Day;
            int mes = hoje.Month;
            int ano = hoje.Year;

            if (dia < 10)
            {
                string data = "0" + dia + "/" + mes + "/" + ano;
                mkbData.Text = data;
            }
            else
            {
                string data = dia + "/" + mes + "/" + ano;
                mkbData.Text = data;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                GastosDTO dto = new GastosDTO();
                dto.Nome = txtNome.Text;
                dto.Descricao = txtDescricao.Text;
                dto.Data = mkbData.Text;
                dto.Valor = nudValor.Value;

                GastosBusiness buss = new GastosBusiness();
                buss.Salvar(dto);

                string msg = "Gasto salvo com sucesso!";

                frmMessage tela = new frmMessage();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
            catch (Exception ex)
            {
                string msg = "Ocorreu um erro: " + ex.Message;

                frmException tela = new frmException();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
        }
    }
}
