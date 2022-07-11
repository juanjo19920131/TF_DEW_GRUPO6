using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using Dapper;
using DBEntity;

namespace DBContext
{
    public class CombustibleRepository : BaseRepository, ICombustibleRepository
    {
        public EntityBaseResponse GetCombustible(int id)
        {
            var response = new EntityBaseResponse(); 

            try
            {
                using (var db = GetSqlConnection())
                {
                    var combustible = new EntityCombustible();
                    const string sql = "usp_ObtenerCombustible";

                    var p = new DynamicParameters();
                    p.Add(name: "@IdCombustible", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    combustible = db.Query<EntityCombustible>(
                        sql: sql,
                        param: p,
                        commandType: CommandType.StoredProcedure
                        ).FirstOrDefault();

                    if (combustible != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = combustible;
                    }
                    else
                    {
                        response.issuccess = false;
                        response.errorcode = "0001";
                        response.errormessage = "Sin Datos";
                        response.data = null;
                    }
                }

            }
            catch (Exception ex)
            {
                response.issuccess = false;
                response.errorcode = "0001";
                response.errormessage = ex.Message;
                response.data = null;
            }

            return response;
        }

        public EntityBaseResponse GetCombustibles()
        {
            var response = new EntityBaseResponse(); 

            try
            {
                using (var db = GetSqlConnection())
                {
                    var combustibles = new List<EntityCombustible>();
                    const string sql = "usp_ListarCombustibles";
                    combustibles = db.Query<EntityCombustible>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();

                    if (combustibles != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = combustibles;
                    }
                    else
                    {
                        response.issuccess = false;
                        response.errorcode = "0001";
                        response.errormessage = "Sin Datos";
                        response.data = null;
                    }
                }
            }
            catch (Exception ex)
            {
                response.issuccess = false;
                response.errorcode = "0001";
                response.errormessage = ex.Message;
                response.data = null;
            }

            return response;
        }
    }
}
