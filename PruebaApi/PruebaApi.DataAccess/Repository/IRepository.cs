using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaApi.BusinessLogic.Repository
{
    interface IRepository<T,U>
    {
        public IEnumerable<U> List();
        public RequestStatus Insert(T item);
        public RequestStatus Update(T item);
        public U find(int? id);
        public RequestStatus Delete(int id);
    }
}
