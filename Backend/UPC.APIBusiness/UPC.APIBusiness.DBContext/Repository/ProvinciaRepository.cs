using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using Dapper;
using DBEntity;

namespace DBContext
{
    public class ProvinciaRepository : BaseRepository, IProvinciaRepository
    {
        public EntityBaseResponse GetProvincia(string cod_dep, string cod_pro)
        {
            var response = new EntityBaseResponse(); 

            try
            {
                using (var db = GetSqlConnection())
                {
                    var provincia = new EntityProvincia();
                    const string sql = "usp_ObtenerProvincia";

                    var p = new DynamicParameters();
                    p.Add(name: "@CodDepartamento", value: cod_dep, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@CodProvincia", value: cod_pro, dbType: DbType.String, direction: ParameterDirection.Input);

                    provincia = db.Query<EntityProvincia>(
                        sql: sql,
                        param: p,
                        commandType: CommandType.StoredProcedure
                        ).FirstOrDefault();

                    if (provincia != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = provincia;
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

        public EntityBaseResponse GetProvincias(string cod_dep)
        {
            var response = new EntityBaseResponse(); 

            try
            {
                using (var db = GetSqlConnection())
                {
                    var provincias = new List<EntityProvincia>();
                    const string sql = "usp_ListarProvinciasPorDepartamento";

                    var p = new DynamicParameters();
                    p.Add(name: "@CodDepartamento", value: cod_dep, dbType: DbType.String, direction: ParameterDirection.Input);

                    provincias = db.Query<EntityProvincia>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();

                    if (provincias != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = provincias;
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
