using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using Dapper;
using DBEntity;

namespace DBContext
{
    public class TipoRevisionRepository : BaseRepository, ITipoRevisionRepository
    {
        public EntityTipoRevision GetTipoRevision(int id)
        {
            var TipoRevision = new EntityTipoRevision();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ObtenerTipoRevision";

                    var p = new DynamicParameters();
                    p.Add(name: "@IdRevision", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    TipoRevision = db.Query<EntityTipoRevision>(
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

            return TipoRevision;
        }

        public List<EntityTipoRevision> GetTipoRevisiones()
        {
            var TipoRevisiones = new List<EntityTipoRevision>();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ListarTipoRevision";
                    TipoRevisiones = db.Query<EntityTipoRevision>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return TipoRevisiones;
        }
    }
}
