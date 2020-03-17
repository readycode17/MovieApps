using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MovieApp.repos.Contracts
{
   public interface IRepository<T> where T:class
   {
       IEnumerable<T> GetAll();

       T GetById(int id);

       void Add(T entity);

       void Update(T entity);

       void Delete(T entity);

       IQueryable<T> FindByConditon(Expression<Func<T, bool>> expression, bool trackChanges);
   }
}
