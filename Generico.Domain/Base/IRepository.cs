﻿using AspNetCore.IQueryable.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Domain.Base
{
    public interface IRepository<T> where T : class
    {
        Task Save(T entity);
        Task Delete(T entity);
        Task Update(T entity);
        Task<T> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> FindAllByCriterio(Expression<Func<T, bool>> expression);
        Task<T> FindOneByCriterio(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<T> GetbyExpressionAsync(Expression<Func<T, bool>> expression);
        public IQueryable<T> GetByQueryable(ICustomQueryable filter);
    }
}
