﻿namespace OrderService.DataAccess.Contracts;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<T> Repository<T>() where T: class;

    Task<int> Complete();
}
