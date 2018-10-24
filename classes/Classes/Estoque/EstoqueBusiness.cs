﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Estoque
{
    public class EstoqueBusiness
    {
        public int Salvar(EstoqueDTO dto)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.Salvar(dto);
        }

        public List<EstoqueView> Listar()
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.Listar();
        }

        public List<EstoqueView> Consultar(string nome)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.Consultar(nome);
        }

        public void Adicionar(int qtd, string nome)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            db.Adicionar(qtd, nome);
        }

        public void Remover(int qtd, string nome)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            db.Remover(qtd, nome);
        }       
    }
}
