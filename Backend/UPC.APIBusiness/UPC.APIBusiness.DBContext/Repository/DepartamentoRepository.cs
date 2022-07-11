using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using Dapper;
using DBEntity;

namespace DBContext
{
    public class DepartamentoRepository : BaseRepository, IDepartamentoRepository
    {
        public EntityBaseResponse GetDepartamento(string codigo)
        {
            var response = new EntityBaseResponse();

            try
            {
                using (var db = GetSqlConnection())
                {
                    var departamento = new EntityDepartamento();
                    const string sql = "usp_ObtenerDepartamento";

                    var p = new DynamicParameters();
                    p.Add(name: "@CodDepartamento", value: codigo, dbType: DbType.String, direction: ParameterDirection.Input);

                    departamento = db.Query<EntityDepartamento>(
                        sql: sql,
                        param: p,
                        commandType: CommandType.StoredProcedure
                        ).FirstOrDefault();

                    if (departamento != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = departamento;
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

        public EntityBaseResponse GetDepartamentos()
        {
            var response = new EntityBaseResponse();

            try
            {
                using (var db = GetSqlConnection())
                {
                    var departamentos = new List<EntityDepartamento>();
                    const string sql = "usp_ListarDepartamentos";

                    departamentos = db.Query<EntityDepartamento>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();

                    if (departamentos != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = departamentos;
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
