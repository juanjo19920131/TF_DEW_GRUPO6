using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using Dapper;
using DBEntity;

namespace DBContext
{
    public class PaisRepository : BaseRepository, IPaisRepository
    {
        public EntityBaseResponse GetPais(string codigo)
        {
            var response = new EntityBaseResponse(); 

            try
            {
                using (var db = GetSqlConnection())
                {
                    var pais = new EntityPais();
                    const string sql = "usp_ObtenerPais";

                    var p = new DynamicParameters();
                    p.Add(name: "@CodPais", value: codigo, dbType: DbType.String, direction: ParameterDirection.Input);

                    pais = db.Query<EntityPais>(
                        sql: sql,
                        param: p,
                        commandType: CommandType.StoredProcedure
                        ).FirstOrDefault();

                    if (pais != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = pais;
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

        public EntityBaseResponse GetPaises()
        {
            var response = new EntityBaseResponse(); 

            try
            {
                using (var db = GetSqlConnection())
                {
                    var paises = new List<EntityPais>();
                    const string sql = "usp_ListarPaises";

                    paises = db.Query<EntityPais>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();

                    if (paises != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = paises;
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
