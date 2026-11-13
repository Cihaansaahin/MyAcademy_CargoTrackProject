using CargoTrack.DataAccess.Context;
using CargoTrack.DataAccess.Repositories.Abstract;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.DataAccess.Repositories.Concrete
{
    public class UnitOfWork :IUnitOfWork
    {
        private readonly CargoTrackDbContext _context;
        private IDbContextTransaction? _transaction;

        public UnitOfWork(CargoTrackDbContext context)
        {
            _context = context;
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public async Task BeginTransactionAsync()
        {
            if (_transaction is not null)
                throw new InvalidOperationException("Zaten açık bir transaction var.");

            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            if (_transaction is null)
                throw new InvalidOperationException("Commit edilecek açık bir transaction yok.");

            await _transaction.CommitAsync();
            await _transaction.DisposeAsync();
            _transaction = null;
        }

        public async Task RollbackTransactionAsync()
        {
            if (_transaction is null)
                return; // geri alınacak bir şey yok

            await _transaction.RollbackAsync();
            await _transaction.DisposeAsync();
            _transaction = null;
        }
    }
}
