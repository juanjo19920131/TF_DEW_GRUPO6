using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using Dapper;
using DBEntity;

namespace DBContext
{
    public class DistritoRepository : BaseRepository, IDistritoRepository
    {
        public EntityBaseResponse GetDistrito(string cod_dep, string cod_pro, string cod_dis)
        {
            var response = new EntityBaseResponse();

            try
            {
                using (var db = GetSqlConnection())
                {
                    var distrito = new EntityDistrito();
                    const string sql = "usp_ObtenerDistrito";

                    var p = new DynamicParameters();
                    p.Add(name: "@CodDepartamento", value: cod_dep, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@CodProvincia", value: cod_pro, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@CodDistrito", value: cod_dis, dbType: DbType.String, direction: ParameterDirection.Input);

                    distrito = db.Query<EntityDistrito>(
                        sql: sql,
                        param: p,
                        commandType: CommandType.StoredProcedure
                        ).FirstOrDefault();

                    if (distrito != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = distrito;
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

        public EntityBaseResponse GetDistritos(string cod_dep, string cod_pro)
        {
            var response = new EntityBaseResponse(); 

            try
            {
                using (var db = GetSqlConnection())
                {
                    var distritos = new List<EntityDistrito>();
                    const string sql = "usp_ListarDistritosPorDepartamento";

                    var p = new DynamicParameters();
                    p.Add(name: "@CodDepartamento", value: cod_dep, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@CodProvincia", value: cod_pro, dbType: DbType.String, direction: ParameterDirection.Input);

                    distritos = db.Query<EntityDistrito>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();

                    if (distritos != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = distritos;
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
