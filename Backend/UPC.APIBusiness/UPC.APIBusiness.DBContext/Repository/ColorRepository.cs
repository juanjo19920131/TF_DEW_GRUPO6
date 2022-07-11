using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using Dapper;
using DBEntity;

namespace DBContext
{
    public class ColorRepository : BaseRepository, IColorRepository
    {
        public EntityBaseResponse GetColor(string codigo)
        {
            var response = new EntityBaseResponse();

            try
            {
                using (var db = GetSqlConnection())
                {
                    var color = new EntityColor();
                    const string sql = "usp_ObtenerColor";

                    var p = new DynamicParameters();
                    p.Add(name: "@CodColor", value: codigo, dbType: DbType.String, direction: ParameterDirection.Input);

                    color = db.Query<EntityColor>(
                        sql: sql,
                        param: p,
                        commandType: CommandType.StoredProcedure
                        ).FirstOrDefault();

                    if (color != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = color;
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

        public EntityBaseResponse GetColores()
        {
            var response = new EntityBaseResponse(); 

            try
            {
                using (var db = GetSqlConnection())
                {
                    var colores = new List<EntityColor>();
                    const string sql = "usp_ListarColores";
                    colores = db.Query<EntityColor>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();

                    if (colores != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = colores;
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

        public EntityBaseResponse GetColoresPorModelo(string codigo)
        {
            var response = new EntityBaseResponse(); 

            try
            {
                using (var db = GetSqlConnection())
                {
                    var colores = new List<EntityColor>();
                    const string sql = "usp_ListarColoresPorModelo";

                    var p = new DynamicParameters();
                    p.Add(name: "@CodColores", value: codigo, dbType: DbType.String, direction: ParameterDirection.Input);

                    colores = db.Query<EntityColor>(
                        sql: sql,
                        param: p,
                        commandType: CommandType.StoredProcedure
                        ).ToList();

                    if (colores != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = colores;
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
