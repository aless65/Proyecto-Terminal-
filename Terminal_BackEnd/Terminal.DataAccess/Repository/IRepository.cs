using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.DataAccess.Repository
{
    interface IRepository<T, U>
    {
        public U Find(int id);
        public IEnumerable<U> List();
        public RequestStatus Insert(T item);
        public RequestStatus Update(T item);
        public RequestStatus Delete(int id);
    }
}
