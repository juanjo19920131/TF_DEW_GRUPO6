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
        public EntityEstado GetEstado(int id)
        {
            var Estado = new EntityEstado();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ObtenerEstado";

                    var p = new DynamicParameters();
                    p.Add(name: "@IdEstado", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    Estado = db.Query<EntityEstado>(
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

            return Estado;
        }

        public List<EntityEstado> GetEstados()
        {
            var Estados = new List<EntityEstado>();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ListarEstados";
                    Estados = db.Query<EntityEstado>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Estados;
        }
    }
}
