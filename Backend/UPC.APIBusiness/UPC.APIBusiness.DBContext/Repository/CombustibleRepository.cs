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
        public EntityCombustible GetCombustible(int id)
        {
            var Combustible = new EntityCombustible();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ObtenerCombustible";

                    var p = new DynamicParameters();
                    p.Add(name: "@IdCombustible", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    Combustible = db.Query<EntityCombustible>(
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

            return Combustible;
        }

        public List<EntityCombustible> GetCombustibles()
        {
            var Combustibles = new List<EntityCombustible>();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ListarCombustibles";
                    Combustibles = db.Query<EntityCombustible>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Combustibles;
        }
    }
}
