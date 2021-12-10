using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ZOI.DAL.Providers.UnitOfWork.Interface
{
    public interface IUnitOfWork<TContext> where TContext : DbContext, IDisposable
    {
        void SaveChanges();

        Task<int> SaveChangesAsync();

       // IRepository<T> Repository<T>() where T : class;

        void ExecSQL<TObj>(string ProcName, out IEnumerable<TObj> Result);

        void ExecSQL<TObj>(string ProcName, SqlParameter[] param, out IEnumerable<TObj> Result);

        DataSet ExecuteDataset(string CommandText, SqlParameter[] SqlParameters, CommandType Type = CommandType.StoredProcedure);

        DataSet ExecuteDataset(string CommandText, DbContextZoi connect, SqlParameter[] SqlParameters, CommandType Type = CommandType.StoredProcedure);

        int ExecuteNonQuery(string CommandText, SqlParameter[] SqlParameters, CommandType Type = CommandType.StoredProcedure);

        #region SSON -- Start -- Register Repository

        //IUserRepository UserRepository { get; }

        //IRoleRepository RoleRepository { get; }

        //IPermissionRepository PermissionRepository { get; }


        //IRightRepository RightRepository { get; }

        //IFontIconRepository FontIconRepository { get; }

        #endregion
    }
}
