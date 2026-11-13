using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.DataAccess.Repositories.Abstract
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();

        // Birden fazla SaveChanges'i (ör. Identity + bizim kayıtlar) tek "ya hep ya hiç" yapmak için
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
    }
}
