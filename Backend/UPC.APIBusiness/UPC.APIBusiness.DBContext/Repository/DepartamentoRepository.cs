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
        public EntityDepartamento GetDepartamento(string codigo)
        {
            var Departamento = new EntityDepartamento();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ObtenerDepartamento";

                    var p = new DynamicParameters();
                    p.Add(name: "@CodDepartamento", value: codigo, dbType: DbType.String, direction: ParameterDirection.Input);

                    Departamento = db.Query<EntityDepartamento>(
                        sql: sql,
                        param: p,
                        commandType: CommandType.StoredProcedure
                        ).FirstOrDefault();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Departamento;
        }

        public List<EntityDepartamento> GetDepartamentos()
        {
            var Departamentos = new List<EntityDepartamento>();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ListarDepartamentos";
                    Departamentos = db.Query<EntityDepartamento>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Departamentos;
        }
    }
}
