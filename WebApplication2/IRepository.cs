using System;
using System.Linq.Expressions;

namespace WebApplication2
{
    public interface IRepository<T> where T : class
    {
        T Get(Expression<Func<T, bool>> predicate = null);
    }
}