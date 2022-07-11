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
        public EntityModelo GetModelo(int id)
        {
            var Modelo = new EntityModelo();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ObtenerModelo";

                    var p = new DynamicParameters();
                    p.Add(name: "@IdModelo", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    Modelo = db.Query<EntityModelo>(
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

            return Modelo;
        }

        public List<EntityModelo> GetModelos(int id)
        {
            var Modelos = new List<EntityModelo>();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ListarModelosPorMarca";

                    var p = new DynamicParameters();
                    p.Add(name: "@IdMarca", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    Modelos = db.Query<EntityModelo>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Modelos;
        }
    }
}
