﻿#region

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

#endregion

namespace Repository.Providers.EntityFramework
{
    public interface IDataContext : IDisposable
    {
        Guid InstanceId { get; }
        DbSet<T> Set<T>() where T : class;
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task<int> SaveChangesAsync();
        void SyncObjectState(object entity);
        IEnumerable<DbEntityEntry> GetEntries();

    }
}