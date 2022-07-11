using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using Dapper;
using DBEntity;

namespace DBContext
{
    public class ModeloRepository : BaseRepository, IModeloRepository
    {
        public EntityBaseResponse GetModelo(int id)
        {
            var response = new EntityBaseResponse(); 

            try
            {
                using (var db = GetSqlConnection())
                {
                    var modelo = new EntityModelo();
                    const string sql = "usp_ObtenerModelo";

                    var p = new DynamicParameters();
                    p.Add(name: "@IdModelo", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    modelo = db.Query<EntityModelo>(
                        sql: sql,
                        param: p,
                        commandType: CommandType.StoredProcedure
                        ).FirstOrDefault();

                    if (modelo != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = modelo;
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

        public EntityBaseResponse GetModelos(int id)
        {
            var response = new EntityBaseResponse(); 

            try
            {
                using (var db = GetSqlConnection())
                {
                    var modelos = new List<EntityModelo>();
                    const string sql = "usp_ListarModelosPorMarca";

                    var p = new DynamicParameters();
                    p.Add(name: "@IdMarca", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    modelos = db.Query<EntityModelo>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();

                    if (modelos != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = modelos;
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
