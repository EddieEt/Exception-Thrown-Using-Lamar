using System;
using System.Linq.Expressions;

namespace WebApplication2
{
    public class TestRepository<T> : IRepository<T> where T : class
    {
        public T Get(Expression<Func<T, bool>> predicate = null)
        {
            return default;
        }
    }
}