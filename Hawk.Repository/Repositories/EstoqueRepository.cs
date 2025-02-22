﻿using Hawk.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hawk.Repository.Repositories
{
    public class EstoqueRepository: IHawkRepository<Estoque>
    {
        private readonly HawkContext context;

        public EstoqueRepository(HawkContext context)
        {
            this.context = context;
        }


        public int Add(Estoque entity)
        {
            entity.RegistroAtivo = true;
            entity.DataEntrada = DateTime.Now;
            context.Estoques.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public bool Delete(int id)
        {
            var estoque = context.Estoques.FirstOrDefault(t => t.Id == id);
            estoque.RegistroAtivo = false;
            context.Estoques.Update(estoque);
            return context.SaveChanges() > 0;
        }

        public Estoque ObterPeloId(int id)
        {
            return context.Estoques.FirstOrDefault(t => t.RegistroAtivo && t.Id == id);
        }

        public List<Estoque> ObterTodos()
        {
            return context.Estoques
                .Include(x => x.Produto)
                .Include(x => x.Empresa)
                .Where(t => t.RegistroAtivo)
                .ToList();
        }

        public bool Update(Estoque entity)
        {
            entity.DataEntrada = DateTime.Now;
            entity.RegistroAtivo = true;
            context.Estoques.Update(entity);
            return context.SaveChanges() > 0;
        }
    }
}
