using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewDawn.Core.Models.Repositories
{
    public class Repository<T>: IDisposable where T : class
    {
        private bool disposed = false;
        private ApplicationDbContext dbContext = null;

        protected DbSet<T> DbSet { get; set; }

        public Repository()
        {
            this.dbContext = new ApplicationDbContext();
            DbSet = dbContext.Set<T>();
        }

        public Repository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<T> GetAll()
        {
            return DbSet.ToList();
        }

        public T Get(int id)
        {
            return DbSet.Find(id);
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            dbContext.Entry<T>(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        public void Dispose()
        {
            if (!disposed)
            {
                dbContext.Dispose();
                disposed = true;
            }
        }
    }
}