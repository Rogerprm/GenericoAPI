﻿using AspNetCore.IQueryable.Extensions;
using Generico.Domain.Base;
using Generico.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Infrastructure.Database
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> Query { get; set; }
        protected DbContext Context { get; set; }

        public Repository(GenericoContext context)
        {
            this.Context = context;
            this.Query = Context.Set<T>();
        }                

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await this.Query.AnyAsync(expression);
        }

        public async Task Delete(T entity)
        {
            this.Query.Remove(entity);
            await this.Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindAllByCriterio(Expression<Func<T, bool>> expression)
        {
            return await this.Query.Where(expression).ToListAsync();
        }

        public async Task<T> FindOneByCriterio(Expression<Func<T, bool>> expression)
        {
            return await this.Query.FirstOrDefaultAsync(expression);
        }

        public async Task<T> GetById(Guid id)
        {
            return await this.Query.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this.Query.ToListAsync();
        }

        public async Task<T> GetbyExpressionAsync(Expression<Func<T, bool>> expression)
        {
            return await Query.FirstOrDefaultAsync(expression);
        }

        public async Task Save(T entity)
        {
            await this.Query.AddAsync(entity);
            await this.Context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            this.Query.Update(entity);
            await this.Context.SaveChangesAsync();
        }

        public IQueryable<T> GetByQueryable(ICustomQueryable filter)
        {
            return Query.AsQueryable().Apply(filter);
        }
    }
}
