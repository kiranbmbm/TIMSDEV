using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Tims.DataAccess;

namespace Tims.DataLayer
{
    public class ApplicationRepository : IApplicationRepository
    {
        private string appCN;

        public ApplicationRepository()
        {
            appCN = ConfigurationManager.ConnectionStrings["TIMS"].ConnectionString;
            if (String.IsNullOrEmpty(appCN))
                throw (new ApplicationException(
                   "ConnectionString for the application configuration is missing from you web.config. "));
        }

        public List<Application> Retrieve()
        {
            List<Application> list = new List<Application>();
            try
            {
                //SqlParameter[] paramsToStore = new SqlParameter[0];
                //paramsToStore[0] = new SqlParameter("@id", SqlDbType.VarChar);
                //paramsToStore[0].Direction = ParameterDirection.Input;
                //paramsToStore[0].Value = "1";
                DataTable dt = SqlService.ExecuteDataTable(appCN, CommandType.StoredProcedure, "GetApplicationList");

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Application a = new Application();
                        a.id = GetDataRowsNullableIntValue(dr, "id");//or you can use this// a.id = dr["id"] != DBNull.Value ? Convert.ToInt32(dr["id"]) : 0;
                        a.name = GetDataRowsStringValue(dr, "name");
                        a.alias = GetDataRowsStringValue(dr, "alias");
                        a.description = GetDataRowsStringValue(dr, "description");
                        a.securedId = GetDataRowsNullableIntValue(dr, "securedid");
                        a.ClientId = GetDataRowsNullableIntValue(dr, "clientid");
                        a.clientAccess = GetDataRowsStringValue(dr, "clientaccess");
                        a.changeManagemenId = GetDataRowsNullableIntValue(dr, "changemanagementid");
                        a.availabilityId = GetDataRowsNullableIntValue(dr, "availabilityid");
                        a.relatedId = GetDataRowsStringValue(dr, "relatedid");
                        a.statusId = GetDataRowsNullableIntValue(dr, "statusid");
                        a.sourceCodeRepositoryId = GetDataRowsNullableIntValue(dr, "sourcecoderepositoryid");
                        a.sourceCodePath = GetDataRowsStringValue(dr, "sourcecodepath");
                        a.actionType = GetDataRowsStringValue(dr, "actiontype");
                        a.amendmentUserId = GetDataRowsNullableIntValue(dr, "amendmentuserid");
                        a.effectiveDate = GetDataRowsStringValue(dr, "effectivedate");
                        list.Add(a);
                    }
                }
              
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return list;
        }

        private int GetDataRowsNullableIntValue(DataRow dr, string ColumnName)
        {
            int value = 0;

            if (dr[ColumnName] != DBNull.Value)
                value = (int)dr[ColumnName];

            return value;
        }
        private string GetDataRowsStringValue(DataRow dr, string ColumnName)
        {
            string value = null;

            if (dr[ColumnName] != DBNull.Value)
                value = dr[ColumnName].ToString();

            return value;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
