﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BulkyDataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class 
    {
        // T - Category
        //CRUD OP
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
   
        void Delete(T entity);
        void RemoveRange(IEnumerable<T> entities);  

    }
    
}
