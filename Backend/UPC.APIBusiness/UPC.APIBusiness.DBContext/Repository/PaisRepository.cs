using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using Dapper;
using DBEntity;

namespace DBContext
{
    public class PaisRepository : BaseRepository, IPaisRepository
    {
        public EntityPais GetPais(string codigo)
        {
            var Pais = new EntityPais();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ObtenerPais";

                    var p = new DynamicParameters();
                    p.Add(name: "@CodPais", value: codigo, dbType: DbType.String, direction: ParameterDirection.Input);

                    Pais = db.Query<EntityPais>(
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

            return Pais;
        }

        public List<EntityPais> GetPaises()
        {
            var Paises = new List<EntityPais>();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ListarPaises";
                    Paises = db.Query<EntityPais>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Paises;
        }
    }
}
