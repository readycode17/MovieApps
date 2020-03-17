using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MovieApp.data.Models;
using MovieApp.repos.Contracts;

namespace MovieApp.repos.Contracts
{
 public class GenericRepository<T>:IRepository<T> where T:class
    {   
        private readonly MovieDBContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(MovieDBContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public IQueryable<T> FindByConditon(Expression<Func<T, bool>> expression, bool trackChanges)
        {
           return _dbSet.Where(expression);
        }

        public IQueryable<T> FindByConitions(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
    }
}
