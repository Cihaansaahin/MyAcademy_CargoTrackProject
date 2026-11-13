using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.DataAccess.Repositories.Abstract
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
