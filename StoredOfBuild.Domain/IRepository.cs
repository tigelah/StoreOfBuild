﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StoredOfBuild.Domain
{
    public interface IRepository<TEntity>
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> All();
        void Save(TEntity entity);
    }
}

