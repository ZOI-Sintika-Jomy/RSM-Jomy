using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using RSM.BAL.DomainModels.Models;
using RSM.BAL.Services.Interface;
using RSM.BAL.Utilities;
using ZOI.DAL.Providers.Infrastructure;
using ZOI_DAL.Providers.Infrastructure;
using static RSM.BAL.Utilities.Constants;
using Constants = RSM.BAL.Utilities.Constants;

namespace RSM.BAL.Services
{
    public class DemoServices : IDemo
    {
        private readonly IDistributedCache _memoryCache;
        private readonly IConfiguration _configuration;
        public DemoServices(IConfiguration configuration, IDistributedCache memoryCache)
        {
            _memoryCache = memoryCache;
            _configuration = configuration;
        }
        public Response Demo()
        {
            Response response = new Response();
           
                try
                {
                    DataSet dataSet = new ADODataFunction().ExecuteDataset(Procedures.Get_Country, null);
                    if (dataSet != null && dataSet.Tables.Count > 0)
                    {
                        // check 1st table  session exist or not
                        DataTable statusDataTable = dataSet.Tables[0];
                        if (statusDataTable != null && statusDataTable.Rows.Count > 0 && statusDataTable.Rows[0]["STATUS"] != null && statusDataTable.Rows[0]["STATUS"].ToString() == Constants.ResponseStatus.Success)
                        {
                            if (dataSet.Tables.Count > 1)
                            {
                                for (int i = 1; i < dataSet.Tables.Count; i++)
                                {
                                    if (dataSet.Tables[i] != null && dataSet.Tables[i].Rows.Count > 0)
                                    {
                                        List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                                        Dictionary<string, object> row;
                                        foreach (DataRow dr in dataSet.Tables[i].Rows)
                                        {
                                            row = new Dictionary<string, object>();
                                            foreach (DataColumn col in dataSet.Tables[i].Columns)
                                            {
                                                row.Add(col.ColumnName, dr[col]);
                                            }
                                            rows.Add(row);
                                        }
                                        response.Data = rows;
                                    }
                                }

                                response.Status = statusDataTable.Rows[0]["STATUS"].ToString();
                                response.Message = statusDataTable.Rows[0]["MESSAGE"].ToString();
                            }
                            else
                            {
                                response.Status = statusDataTable.Rows[0]["STATUS"].ToString();
                                response.Message = statusDataTable.Rows[0]["MESSAGE"].ToString();
                            }

                        }
                        else
                        {
                            response.Status = statusDataTable.Rows[0]["STATUS"].ToString();
                            response.Message = statusDataTable.Rows[0]["MESSAGE"].ToString();
                        }
                    }
                    else
                    {
                        response.Status = ResponseStatus.Failed;
                        response.Message = ResponseMessages.ServerError;
                    }
                }
                catch (Exception ex)
                {
                    response.Status = ResponseStatus.Failed;
                    response.Message = ex.Message;
                    //StackTrace CallStack = new StackTrace(ex, true);
                    //ex.Data["ErrDescription"] = ex.Data["ErrDescription"] != null ? ex.Data["ErrDescription"] : string.Format("Error captured in {0} on Line No {1} of Method {2}", CallStack.GetFrame(0).GetFileName(), CallStack.GetFrame(0).GetFileLineNumber(), CallStack.GetFrame(0).GetMethod().ToString());
                    //StoreErrorLog("DashboardService", CallStack.GetFrame(0).GetMethod().Name.ToString(), ex.Message);
                }
              
            return response;
        }
    }
}
