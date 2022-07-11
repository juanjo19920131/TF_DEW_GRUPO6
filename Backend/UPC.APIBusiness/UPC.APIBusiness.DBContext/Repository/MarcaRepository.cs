using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using Dapper;
using DBEntity;

namespace DBContext
{
    public class MarcaRepository : BaseRepository, IMarcaRepository
    {
        public EntityMarca GetMarca(int id)
        {
            var marca = new EntityMarca();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ObtenerMarca";

                    var p = new DynamicParameters();
                    p.Add(name: "@IdMarca", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    marca = db.Query<EntityMarca>(
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

            return marca;
        }

        public List<EntityMarca> GetMarcas()
        {
            var marcas = new List<EntityMarca>();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ListarMarcas";
                    marcas = db.Query<EntityMarca>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return marcas;
        }
    }
}
