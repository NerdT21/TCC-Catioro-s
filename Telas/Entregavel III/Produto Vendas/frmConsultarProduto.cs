﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catiotro_s.classes.Classes.Agenda;
using Catiotro_s.classes.Classes.Vendas.Produto;
using Catiotro_s.CustomException.TelasException;
using Catiotro_s.Telas.Entregavel_III.Produto_Vendas;

namespace Catiotro_s.Telas.Entregavel_II.Produto
{
    public partial class frmConsultarProduto : UserControl
    {
        public frmConsultarProduto()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            ProdutoBusiness buss = new ProdutoBusiness();
            List<ProdutoDTO> lista = buss.Listar();

            dgvProduto.DataSource = lista;
        }

        void CarregarGrid()
        {
            string nome = txtNome.Text;
            string marca = txtMarca.Text;

            ProdutoBusiness buss = new ProdutoBusiness();
            List<ProdutoDTO> lista = buss.Consultar(nome, marca);

            dgvProduto.DataSource = lista;
        }

        private void lblprocurar_Click(object sender, EventArgs e)
        {

        }

        ProdutoDTO produto;

        private void dgvFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            produto = dgvProduto.Rows[e.RowIndex].DataBoundItem as ProdutoDTO;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void txtprocurar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmConsultarProduto_Load(object sender, EventArgs e)
        {
            //Design das Linhas
            dgvProduto.BorderStyle = BorderStyle.None;
            dgvProduto.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 116, 186);
            dgvProduto.RowsDefaultCellStyle.BackColor = Color.FromArgb(0, 81, 130);
            dgvProduto.RowsDefaultCellStyle.ForeColor = Color.White;

            //Design da seleção de células da GV e da GV "pelada"
            dgvProduto.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProduto.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvProduto.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvProduto.BackgroundColor = Color.White;

            //Estilo da GV
            dgvProduto.EnableHeadersVisualStyles = false;
            dgvProduto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProduto.RowHeadersVisible = false;

            //Cabeça da GV
            dgvProduto.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvProduto.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            //Fonte
            dgvProduto.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 12);
            dgvProduto.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvProduto.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (produto == null)
            {
                string msg = "selecione um registro para alterá-lo";

                frmAlert tela = new frmAlert();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
            else
            {
                frmAlterarProduto form = new frmAlterarProduto();
                form.LoadScreen(produto);
                form.ShowDialog();

                CarregarGrid();
            }
        }
    }
}
