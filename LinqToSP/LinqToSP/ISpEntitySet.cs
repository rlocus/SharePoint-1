﻿using SP.Client.Linq.Infrastructure;
using SP.Client.Linq.Query;
using System.Linq;

namespace SP.Client.Linq
{
    public interface ISpEntitySet
    {
        SpQueryArgs<ISpEntryDataContext> SpQueryArgs { get; }
    }

    public interface ISpEntitySet<TEntity> : ISpEntitySet<TEntity, ISpEntryDataContext>
         where TEntity : class, IListItemEntity
    {
    }

    public interface ISpEntitySet<TEntity, TContext> : IQueryable<TEntity>, ISpRepository<TEntity>, ISpEntitySet
         where TEntity : class, IListItemEntity
         where TContext : class, ISpEntryDataContext
    {
    }
}
