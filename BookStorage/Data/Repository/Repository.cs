using Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Data.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly BookStorageContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;
        public Repository()
        {
            this.context = DataContextFactory.GetBookStorageContext();
            entities = context.Set<T>();
        }
        public IQueryable<T> GetAll()
        {
            return entities.AsQueryable();
        }
        public T Get(long id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }
        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }
        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}
