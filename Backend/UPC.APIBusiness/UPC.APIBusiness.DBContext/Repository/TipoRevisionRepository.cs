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
        public EntityBaseResponse GetTipoRevision(int id)
        {
            var response = new EntityBaseResponse(); 

            try
            {
                using (var db = GetSqlConnection())
                {
                    var tipoRevision = new EntityTipoRevision();
                    const string sql = "usp_ObtenerTipoRevision";

                    var p = new DynamicParameters();
                    p.Add(name: "@IdRevision", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    tipoRevision = db.Query<EntityTipoRevision>(
                        sql: sql,
                        param: p,
                        commandType: CommandType.StoredProcedure
                        ).FirstOrDefault();

                    if (tipoRevision != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = tipoRevision;
                    }
                    else
                    {
                        response.issuccess = false;
                        response.errorcode = "0001";
                        response.errormessage = "Sin Datos";
                        response.data = null;
                    }
                }

            }
            catch (Exception ex)
            {
                response.issuccess = false;
                response.errorcode = "0001";
                response.errormessage = ex.Message;
                response.data = null;
            }

            return response;
        }

        public EntityBaseResponse GetTipoRevisiones()
        {
            var response = new EntityBaseResponse(); 

            try
            {
                using (var db = GetSqlConnection())
                {
                    var tipoRevisiones = new List<EntityTipoRevision>();
                    const string sql = "usp_ListarTipoRevision";

                    tipoRevisiones = db.Query<EntityTipoRevision>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();

                    if (tipoRevisiones != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = tipoRevisiones;
                    }
                    else
                    {
                        response.issuccess = false;
                        response.errorcode = "0001";
                        response.errormessage = "Sin Datos";
                        response.data = null;
                    }
                }
            }
            catch (Exception ex)
            {
                response.issuccess = false;
                response.errorcode = "0001";
                response.errormessage = ex.Message;
                response.data = null;
            }

            return response;
        }
    }
}
