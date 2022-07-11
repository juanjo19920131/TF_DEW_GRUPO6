using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using Dapper;
using DBEntity;

namespace DBContext
{
    public class CarroceriaRepository : BaseRepository, ICarroceriaRepository
    {
        public EntityCarroceria GetCarroceria(int id)
        {
            var Carroceria = new EntityCarroceria();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ObtenerCarroceria";

                    var p = new DynamicParameters();
                    p.Add(name: "@IdCarroceria", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    Carroceria = db.Query<EntityCarroceria>(
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

            return Carroceria;
        }

        public List<EntityCarroceria> GetCarrocerias()
        {
            var Carrocerias = new List<EntityCarroceria>();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ListarCarrocerias";
                    Carrocerias = db.Query<EntityCarroceria>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Carrocerias;
        }
    }
}
