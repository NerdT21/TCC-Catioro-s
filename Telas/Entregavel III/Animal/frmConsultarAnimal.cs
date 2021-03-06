﻿using System;
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
using Catiotro_s.CustomException.TelasException;
using Catiotro_s.Telas.Entregavel_III.Animal;

namespace Catiotro_s.Consultar
{
    public partial class frmConsultarAnimal : UserControl
    {
        public frmConsultarAnimal()
        {
            InitializeComponent();
            AutoCarregar();
        }
        void AutoCarregar()
        {
            AnimalBusiness business = new AnimalBusiness();
            List<AnimalView> lista = business.Listar();

            dgvAnimal.DataSource = lista;
        }
        void CarregarGrid()
        {
            string nome = txtAnimal.Text;
            string nomeDono = txtDono.Text;

            AnimalBusiness buss = new AnimalBusiness();
            List<AnimalView> lista = buss.Consultar(nome, nomeDono);

            dgvAnimal.DataSource = lista;
        }
       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        AnimalView animal;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            animal = dgvAnimal.Rows[e.RowIndex].DataBoundItem as AnimalView;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();
            }
            catch (Exception ex)
            {
                string msg = "Ocorreu um erro: " + ex.Message;

                frmException tela = new frmException();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmConsultarAnimal_Load(object sender, EventArgs e)
        {
            //Design das Linhas
            dgvAnimal.BorderStyle = BorderStyle.None;
            dgvAnimal.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 116, 186);
            dgvAnimal.RowsDefaultCellStyle.BackColor = Color.FromArgb(0, 81, 130);
            dgvAnimal.RowsDefaultCellStyle.ForeColor = Color.White;

            //Design da seleção de células da GV e da GV "pelada"
            dgvAnimal.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAnimal.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvAnimal.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvAnimal.BackgroundColor = Color.White;

            //Estilo da GV
            dgvAnimal.EnableHeadersVisualStyles = false;
            dgvAnimal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAnimal.RowHeadersVisible = false;

            //Cabeça da GV
            dgvAnimal.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvAnimal.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            //Fonte
            dgvAnimal.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 12);
            dgvAnimal.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvAnimal.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (animal == null)
            {
                string msg = "Selecione um registro para alterá-lo";

                frmAlert tela = new frmAlert();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
            else
            {
                frmAlterarAnimal screen = new frmAlterarAnimal();
                screen.LoadScreen(animal);
                screen.ShowDialog();

                CarregarGrid();
            }          
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (animal == null)
            {
                string msg = "Selecione um registro para removê-lo";

                frmAlert tela = new frmAlert();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
            else
            {
                string msg = "Quer mesmo remover o registro " + animal.Id + "?";
                frmQuestion tela = new frmQuestion();
                tela.LoadScreen(msg);
                tela.ShowDialog();

                bool click = tela.BotaoYes;

                if (click == true)
                {
                    AnimalBusiness buss = new AnimalBusiness();
                    buss.Remover(animal.Id);

                    CarregarGrid();
                }
            }
        }
    }
}
