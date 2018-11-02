using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catiotro_s.classes.Classes.Animal;
using Catiotro_s.classes.Classes.AddConsultar.Animal;
using Catiotro_s.classes.Classes.Compras.Item;
using Catiotro_s.classes.Classes.Servicos;
using Catiotro_s.CustomException.TelasException;
using Catiotro_s.CustomException;

namespace Catiotro_s.Telas.Entregavel_III.Servicos
{
    public partial class frmServico : UserControl
    {
        public frmServico()
        {
            InitializeComponent();
            DataParaHoje();
            CarregarCombos();
        }

        BindingList<ItemDTO> itemAdd = new BindingList<ItemDTO>();
        List<decimal> valor = new List<decimal>();

        void DataParaHoje()
        {
            DateTime hoje = DateTime.Now;
            int dia = hoje.Day;
            int mes = hoje.Month;
            int ano = hoje.Year;

            string data = dia + "/" + mes + "/" + ano;
            mkbData.Text = data;
        }

        void CarregarCombos()
        {
            AnimalBusiness animalBuss = new AnimalBusiness();
            List<AnimalView> animalDTO = animalBuss.Listar();

            cboAnimal.ValueMember = nameof(AnimalView.Id);
            cboAnimal.DisplayMember = nameof(AnimalView.Nome);
            cboAnimal.DataSource = animalDTO;

            ItemBusiness itemBuss = new ItemBusiness();
            List<ItemDTO> itemDTO = itemBuss.Listar();

            cboProduto.ValueMember = nameof(ItemDTO.Id);
            cboProduto.DisplayMember = nameof(ItemDTO.Nome);
            cboProduto.DataSource = itemDTO;
        }

        void CarregarGrid()
        {
            dgvCarrinho.AutoGenerateColumns = false;
            dgvCarrinho.DataSource = itemAdd;
        }

        private void frmServico_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ItemDTO dto = cboProduto.SelectedItem as ItemDTO;

                int quantidade = Convert.ToInt32(nudQtd.Value);

                for (int i = 0; i < quantidade; i++)
                {
                    itemAdd.Add(dto);
                }

                CarregarGrid();

                valor.Add(dto.Preco * quantidade);
                nudValor.Value = Convert.ToDecimal(valor.Sum());
            }
            catch (Exception ex)
            {
                string msg = "Ocorreu um erro: " + ex.Message;

                frmException tela = new frmException();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                AnimalDTO animal = cboAnimal.SelectedItem as AnimalDTO;

                ServicoDTO dto = new ServicoDTO();
                dto.IdAnimal = animal.Id;
                dto.Data = mkbData.Text;
                dto.Servico = txtDescricao.Text;
                dto.Valor = nudValor.Value;

                ServicoBusiness buss = new ServicoBusiness();
                int pk = buss.Salvar(dto, itemAdd.ToList());

                string msg = "Serviço salvo concluido com sucesso!";

                frmMessage tela = new frmMessage();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
            catch (ValidacaoException vex)
            {
                frmAlert tela = new frmAlert();
                tela.LoadScreen(vex.Message);
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
