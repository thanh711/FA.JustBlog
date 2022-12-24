using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Infrastructures
{
    /// <summary>
    /// Base repository implement some basic CRUD functions
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Change state of entity to added
        /// </summary>
        /// <param name="entity"></param>
        void Create(TEntity entity);

        /// <summary>
        /// Change state of entity to deleted
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);

        /// <summary>
        /// Change state of entity to deleted
        /// </summary>
        /// <param name="entity"></param>
        void Delete(params object[] ids);

        /// <summary>
        /// Change state of entity to modified
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);

        /// <summary>
        /// Get all <paramref name="TEntity"></paramref> from database
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Get object by primaryKey
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        TEntity GetById(params object[] primaryKey);

        /// <summary>
        /// Get object by predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);

        /// <summary>
        /// Get paging object 
        /// </summary>
        /// <param name="orderBy"></param>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        IEnumerable<TEntity> GetPaging(int currentPage, int pageSize,IOrderedEnumerable<TEntity> orderBy=null,  string filter = null);
    }
}
