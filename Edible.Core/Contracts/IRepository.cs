using Edible.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edible.Core.Models;

namespace Edible.Core.Contracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Collection();
        void Commit();
        T Find(string Id);
        void Insert(T t);
        void Update(T t);

    }
}
