using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDAL
{
    public interface IDao<TEntity>
    {
        IEnumerable<TEntity> GetAll();
    }
}
