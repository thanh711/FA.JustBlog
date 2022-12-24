using FA.JustBlog.Core.Data;
using FA.JustBlog.Core.Enum;
using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Infrastructures
{
    
    public abstract class BaseRepository<TEntity> :IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly JustBlogContext context;
        protected DbSet<TEntity> DbSet;

        public BaseRepository(JustBlogContext context)
        {
            this.context = context;
            DbSet = context.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
             DbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            entity.Status = Status.Deleted;
            DbSet.Update(entity);
        }

        public void Delete(params object[] ids)
        {
            TEntity entity = GetById(ids);
            Delete(entity);
        }

        public IEnumerable<TEntity> Find(Func<TEntity, bool> predicate)
        {
            return DbSet.Where(t=>t.Status==Status.Actived)
                .Where(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.Where(t=>t.Status==Status.Actived).ToList();
        }

        public TEntity GetById(params object[] primaryKey)
        {
            TEntity searchResult= DbSet.Find(primaryKey);
            if (searchResult != null)
            {
                return searchResult.Status == Status.Actived ? searchResult : null;
            }
            return null;
        }

        public IEnumerable<TEntity> GetPaging(int currentPage, int pageSize,IOrderedEnumerable<TEntity> orderBy = null,  string filter = null)
        {
            if (orderBy == null)
            {
                return DbSet.Where(t => t.Status == Status.Actived)
                               .Skip((currentPage - 1) * pageSize)
                               .Take(pageSize);
            }
            return orderBy.Where(t => t.Status == Status.Actived)
                .Skip((currentPage-1)* pageSize)
                .Take(pageSize);
        }

        public void Update(TEntity entity)
        {
            BeforeSave(entity);
            DbSet.Update(entity);
        }
        public void BeforeSave(TEntity entity)
        {
            if (context.Entry(entity).State == EntityState.Added)
            {
                entity.CreateAt = DateTime.Now;
            }
            entity.UpdateAt = DateTime.Now;
        }
    }
}
