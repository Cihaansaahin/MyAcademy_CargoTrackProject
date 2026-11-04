using CargoTrack.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CargoTrack.DataAccess.Repositories.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        // Okuma
        IQueryable<T> GetQueryable(bool asNoTracking = true);
        Task<T?>GetByIdAsync(int id);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);


        // Yazma (kaydetmez, sadece işaretler)
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(T entity);
    }
}
