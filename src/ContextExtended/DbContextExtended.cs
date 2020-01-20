using Microsoft.EntityFrameworkCore;
using mxcd.contextExtended.model;
using mxcd.linqToSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using System.Data.Common;
using mxcd.dbContextExtended.exception;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;

namespace mxcd.dbContextExtended
{
    internal enum TypeAction
    {
        update = 1,
        delete = 2
    }

    internal class SqlAction
    {
        public Action<DbConnection> Action { get; set; }
        public TypeAction TypeAction { get; set; }
    }
    /// <summary>
    /// Context extended
    /// </summary>
    public class DbContextExtended : DbContext
    {
        List<SqlAction> actions = new List<SqlAction>();
        ILinqToSql linqToSql = new LinqToSqlFactory().Create(LinqToSqlType.SqlServer);
        private void executeAcions()
        {
            var connection = this.Database.GetDbConnection();
            connection.Open();
            try
            {
                actions.OrderBy(x => x.TypeAction).ToList().ForEach(x => x.Action(connection));
                actions.Clear();
            }
            catch (Exception) { throw; }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="options"></param>
        public DbContextExtended(DbContextOptions options) : base(options)
        {

        }
        /// <summary>
        /// Ctor
        /// </summary>
        protected DbContextExtended()
        {

        }
        /// <summary>
        /// SaveChanges
        /// </summary>
        /// <param name="acceptAllChangesOnSuccess"></param>
        /// <returns></returns>
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required))
            {
                var rerult = base.SaveChanges(acceptAllChangesOnSuccess);
                executeAcions();
                scope.Complete();
                return rerult;
            }
        }
        /// <summary>
        /// SaveChangesAsync
        /// </summary>
        /// <param name="acceptAllChangesOnSuccess"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required))
            {
                var rerult = base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
                executeAcions();
                scope.Complete();
                return rerult;
            }
        }
        /// <summary>
        /// Remove de database entities with a expression and a given data (anonymous type permited)
        /// This method not removes de session entities, for this propouse use context.ChangeTracker.Entries...
        /// This method will executed on SaveChanges 
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="expr">filter</param>
        public void Remove<T>(Expression<Func<T, bool>> expr = null) where T : class
        {
            var data = GetTableData<T>();
            var query = linqToSql.From(data.Table, data.Schema).Where(expr).Delete();
            actions.Add(new SqlAction()
            {
                Action = c =>
                {
                    try
                    {
                        var command = c.CreateCommand();
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                    catch (Exception oEx) { throw new DbContextExtendedException($"Error on remove: {query}", oEx); }
                },
                TypeAction = TypeAction.delete
            });
        }
        /// <summary>
        /// Update the database entities with a expression and a given data (anonymous type permited)
        /// This method not updates de session entities, for this propouse use context.ChangeTracker.Entries...
        /// This method will executed on SaveChanges
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <typeparam name="TUpdate">Type of update</typeparam>
        /// <param name="obj">Entity value for update</param>
        /// <param name="expr">filter</param>
        public void Update<T, TUpdate>(TUpdate obj, Expression<Func<T, bool>> expr) where T : class where TUpdate : class
        {
            var data = GetTableData<T>();
            var query = linqToSql.From(data.Table, data.Schema).Where(expr).Update(obj);

            actions.Add(new SqlAction()
            {
                Action = c =>
                {
                    try
                    {
                        var command = c.CreateCommand();
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                    catch (Exception oEx) { throw new DbContextExtendedException($"Error on update: {query}", oEx); }
                },
                TypeAction = TypeAction.update
            });
        }

        internal ITableData GetTableData<T>()
        {
            ITableData result = null;

            var names = this.Model.GetEntityTypes();
            var type = names.Single(x => x.ClrType == typeof(T));

            if (type != null)
            {
                result = new TableData
                {
                    Keys = type.GetKeys().ToList()[0].Properties.Select(x => x.Name).ToList(),
                    Schema = type.GetDefaultSchema(),
                    Table = type.GetDefaultTableName(),
                    Properties = type.GetProperties().Select(x => x.Name).ToList()
                };
            }

            return result;
        }
        /// <summary>
        /// Dispose
        /// </summary>
        public override void Dispose()
        {
            actions.Clear();
            base.Dispose();
        }
        /// <summary>
        /// Dispose
        /// </summary>
        /// <returns></returns>
        public override ValueTask DisposeAsync()
        {
            actions.Clear();
            return base.DisposeAsync();
        }
        /// <summary>
        /// DiscardChanges
        /// </summary>
        public void DiscardChanges()
        {
            actions.Clear();

            foreach (var entry in this.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified; //Revert changes made to deleted entity.
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                }
            }
        }
        /// <summary>
        /// DiscardChanges
        /// </summary>
        public void DiscardChanges<T>(Expression<Func<T, bool>> filter = null) where T : class
        {
            actions.Clear();

            var entries = this.ChangeTracker.Entries<T>();
            if (filter != null)
            {
                entries = entries.Where(x => filter.Compile()(x.Entity));
            }
            foreach (var entry in entries)
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                }
            }
        }
        /// <summary>
        /// Async DiscardChanges
        /// </summary>
        public Task DiscardChangesAsync()
        {
            return Task.Run(this.DiscardChanges);
        }
        /// <summary>
        /// Async DiscardChanges
        /// </summary>
        public Task DiscardChangesAsync<T>(Expression<Func<T, bool>> filter = null) where T : class
        {
            return Task.Run(()=>this.DiscardChanges<T>(filter));
        }
    }
}
