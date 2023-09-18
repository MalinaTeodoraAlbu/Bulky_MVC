using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Bulky.DataAccess.Data;
using BulkyDataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BulkyDataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;

        internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext db)
        {
            _db = db;   
            this.dbSet = _db.Set<T>();
            //_db.Categories == dbSet;
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> querry = dbSet;
            querry= querry.Where(filter);
            return querry.FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> querry = dbSet;

            return querry.ToList();
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
        }
    }
}
