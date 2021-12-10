using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Tasks;
using ZOI.DAL.Providers.UnitOfWork.Interface;
using ZOI_DAL.Providers.Infrastructure;
using Disposable = ZOI.DAL.Providers.Infrastructure.Disposable;

namespace ZOI.DAL.Providers.UnitOfWork
{
    public enum DbContextZoi
    {
        DBContextZoi
    }

    public class UnitOfWork<TContext> : Disposable, IUnitOfWork<TContext> where TContext : DbContext, new()
    {
        private DbContext _context;
        //private Hashtable _repositories;

        protected override void DisposeCore()
        {
            if (_context != null)
                _context.Dispose();
        }

        public UnitOfWork()
        {
            _context = new TContext();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                StackTrace CallStack = new StackTrace(ex, true);
                ex.Data["ErrDescription"] = ex.Data["ErrDescription"] != null ? ex.Data["ErrDescription"] : string.Format("Error captured in {0} on Line No {1} of Method {2}", CallStack.GetFrame(0).GetFileName(), CallStack.GetFrame(0).GetFileLineNumber(), CallStack.GetFrame(0).GetMethod().ToString());
                throw ex;
            }
        }

        public void ExecSQL<TObj>(string ProcName, out IEnumerable<TObj> Result)
        {
            try
            {
                Result = new ADODataFunction().ExecSQL<TObj>(ProcName);
            }
            catch (Exception ex)
            {
                StackTrace CallStack = new StackTrace(ex, true);
                ex.Data["ErrDescription"] = ex.Data["ErrDescription"] != null ? ex.Data["ErrDescription"] : string.Format("Error captured in {0} on Line No {1} of Method {2}", CallStack.GetFrame(0).GetFileName(), CallStack.GetFrame(0).GetFileLineNumber(), CallStack.GetFrame(0).GetMethod().ToString());
                throw ex;
            }
        }

        public void ExecSQL<TObj>(string ProcName, SqlParameter[] param, out IEnumerable<TObj> Result)
        {
            try
            {
                Result = new ADODataFunction().ExecSQL<TObj>(ProcName, param);
            }
            catch (Exception ex)
            {
                StackTrace CallStack = new StackTrace(ex, true);
                ex.Data["ErrDescription"] = ex.Data["ErrDescription"] != null ? ex.Data["ErrDescription"] : string.Format("Error captured in {0} on Line No {1} of Method {2}", CallStack.GetFrame(0).GetFileName(), CallStack.GetFrame(0).GetFileLineNumber(), CallStack.GetFrame(0).GetMethod().ToString());
                throw ex;
            }
        }

        public DataSet ExecuteDataset(string CommandText, SqlParameter[] SqlParameters, CommandType Type = CommandType.StoredProcedure)
        {
            ADODataFunction ADODataFunction = new ADODataFunction();
            try
            {
                return ADODataFunction.ExecuteDataset(CommandText, SqlParameters, Type);
            }
            catch (Exception ex)
            {
                StackTrace CallStack = new StackTrace(ex, true);
                ex.Data["ErrDescription"] = ex.Data["ErrDescription"] != null ? ex.Data["ErrDescription"] : string.Format("Error captured in {0} on Line No {1} of Method {2}", CallStack.GetFrame(0).GetFileName(), CallStack.GetFrame(0).GetFileLineNumber(), CallStack.GetFrame(0).GetMethod().ToString());
                throw ex;
            }
            finally
            {
                ADODataFunction.Dispose();
            }
        }

        public DataSet ExecuteDataset(string CommandText, DbContextZoi connect, SqlParameter[] SqlParameters, CommandType Type = CommandType.StoredProcedure)
        {
            ADODataFunction ADODataFunction = new ADODataFunction();
            try
            {
                return ADODataFunction.ExecuteDataset(CommandText, connect, SqlParameters, Type);
            }
            catch (Exception ex)
            {
                StackTrace CallStack = new StackTrace(ex, true);
                ex.Data["ErrDescription"] = ex.Data["ErrDescription"] != null ? ex.Data["ErrDescription"] : string.Format("Error captured in {0} on Line No {1} of Method {2}", CallStack.GetFrame(0).GetFileName(), CallStack.GetFrame(0).GetFileLineNumber(), CallStack.GetFrame(0).GetMethod().ToString());
                throw ex;
            }
            finally
            {
                ADODataFunction.Dispose();
            }
        }

        public int ExecuteNonQuery(string CommandText, SqlParameter[] SqlParameters, CommandType Type = CommandType.StoredProcedure)
        {
            ADODataFunction ADODataFunction = new ADODataFunction();
            try
            {
                return ADODataFunction.ExecuteNonQuery(CommandText, SqlParameters, Type);
            }
            catch (Exception ex)
            {
                StackTrace CallStack = new StackTrace(ex, true);
                ex.Data["ErrDescription"] = ex.Data["ErrDescription"] != null ? ex.Data["ErrDescription"] : string.Format("Error captured in {0} on Line No {1} of Method {2}", CallStack.GetFrame(0).GetFileName(), CallStack.GetFrame(0).GetFileLineNumber(), CallStack.GetFrame(0).GetMethod().ToString());
                throw ex;
            }
            finally
            {
                ADODataFunction.Dispose();
            }
        }



    }
}
