using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using Dapper;
using DBEntity;

namespace DBContext
{
    public class DistritoRepository : BaseRepository, IDistritoRepository
    {
        public EntityDistrito GetDistrito(string cod_dep, string cod_pro, string cod_dis)
        {
            var Distrito = new EntityDistrito();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ObtenerDistrito";

                    var p = new DynamicParameters();
                    p.Add(name: "@CodDepartamento", value: cod_dep, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@CodProvincia", value: cod_pro, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@CodDistrito", value: cod_dis, dbType: DbType.String, direction: ParameterDirection.Input);

                    Distrito = db.Query<EntityDistrito>(
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

            return Distrito;
        }

        public List<EntityDistrito> GetDistritos(string cod_dep, string cod_pro)
        {
            var Distritos = new List<EntityDistrito>();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ListarDistritosPorDepartamento";

                    var p = new DynamicParameters();
                    p.Add(name: "@CodDepartamento", value: cod_dep, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@CodProvincia", value: cod_pro, dbType: DbType.String, direction: ParameterDirection.Input);

                    Distritos = db.Query<EntityDistrito>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Distritos;
        }
    }
}
