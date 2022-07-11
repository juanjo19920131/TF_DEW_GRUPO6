using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using Dapper;
using DBEntity;

namespace DBContext
{
    public class ProvinciaRepository : BaseRepository, IProvinciaRepository
    {
        public EntityProvincia GetProvincia(string cod_dep, string cod_pro)
        {
            var Provincia = new EntityProvincia();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ObtenerProvincia";

                    var p = new DynamicParameters();
                    p.Add(name: "@CodDepartamento", value: cod_dep, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@CodProvincia", value: cod_pro, dbType: DbType.String, direction: ParameterDirection.Input);

                    Provincia = db.Query<EntityProvincia>(
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

            return Provincia;
        }

        public List<EntityProvincia> GetProvincias(string cod_dep)
        {
            var Provincias = new List<EntityProvincia>();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ListarProvinciasPorDepartamento";

                    var p = new DynamicParameters();
                    p.Add(name: "@CodDepartamento", value: cod_dep, dbType: DbType.String, direction: ParameterDirection.Input);

                    Provincias = db.Query<EntityProvincia>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Provincias;
        }
    }
}
