using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson24
{
    internal interface IGeneralInterface<T>
    {
        List<T> GetAll();
        T GetById(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(int id);
    }
}
