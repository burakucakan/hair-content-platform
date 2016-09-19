using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairCare.DB
{
    public class Context : LorealHairCareEntities
    {

        public DbSet<TEntity> GetTable<TEntity>() where TEntity : class
        {
            return this.Set<TEntity>();
        }

    }
}
