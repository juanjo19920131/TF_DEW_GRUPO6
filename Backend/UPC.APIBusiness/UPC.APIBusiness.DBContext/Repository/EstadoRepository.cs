using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using Dapper;
using DBEntity;

namespace DBContext
{
    public class EstadoRepository : BaseRepository, IEstadoRepository
    {
        public EntityBaseResponse GetEstado(int id)
        {
            var response = new EntityBaseResponse(); 

            try
            {
                using (var db = GetSqlConnection())
                {
                    var estado = new EntityEstado();
                    const string sql = "usp_ObtenerEstado";

                    var p = new DynamicParameters();
                    p.Add(name: "@IdEstado", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    estado = db.Query<EntityEstado>(
                        sql: sql,
                        param: p,
                        commandType: CommandType.StoredProcedure
                        ).FirstOrDefault();

                    if (estado != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = estado;
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

        public EntityBaseResponse GetEstados()
        {
            var response = new EntityBaseResponse(); 

            try
            {
                using (var db = GetSqlConnection())
                {
                    var estados = new List<EntityEstado>();
                    const string sql = "usp_ListarEstados";

                    estados = db.Query<EntityEstado>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();

                    if (estados != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = estados;
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
