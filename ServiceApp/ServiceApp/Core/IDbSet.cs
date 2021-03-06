﻿using System;
using System.Collections.Generic;

namespace ServiceApp.Core
{
    public interface IDbSet<T> where T : class
    {
        T Add(T item);
        T Exists(T item);
        T Exists(Func<T, bool> predicate);
        IEnumerable<T> GetAll();
        T GetById(int Id);
        void Remove(T item);
        void Update(T item);
    }
}