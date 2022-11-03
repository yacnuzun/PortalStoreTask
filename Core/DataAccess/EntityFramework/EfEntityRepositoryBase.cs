using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TContext,TEntity>
        where TEntity : class,IEntity,new()
        where TContext: DbContext,new()
    {
        public bool Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var entityAdded = context.Entry(entity);
                entityAdded.State = EntityState.Added;
                context.SaveChanges();
                return true;
            }
        }

        public bool Delete(TEntity entity)
        {
            try
            {
                using (TContext context = new TContext())
                {
                    var entityAdded = context.Entry(entity);
                    entityAdded.State = EntityState.Deleted;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }


        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public bool Update(TEntity entity)
        {

            using (TContext context = new TContext())
            {
                var entityAdded = context.Entry(entity);
                entityAdded.State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }

        }
    }
}
