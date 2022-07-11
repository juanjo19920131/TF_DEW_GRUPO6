using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using Dapper;
using DBEntity;

namespace DBContext
{
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
    {
        public EntityBaseResponse GetUsuario(int id)
        {
            var response = new EntityBaseResponse(); 

            try
            {
                using (var db = GetSqlConnection())
                {
                    var usuario = new EntityUsuario();
                    const string sql = "usp_ObtenerUsuario";

                    var p = new DynamicParameters();
                    p.Add(name: "@IdUsuario", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    usuario = db.Query<EntityUsuario>(
                        sql: sql,
                        param: p,
                        commandType: CommandType.StoredProcedure
                        ).FirstOrDefault();

                    if (usuario != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = usuario;
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

        public EntityBaseResponse GetUsuarios()
        {
            var response = new EntityBaseResponse(); 

            try
            {
                using (var db = GetSqlConnection())
                {
                    var usuarios = new List<EntityUsuario>();
                    const string sql = "usp_ListarUsuarios";

                    usuarios = db.Query<EntityUsuario>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();

                    if (usuarios != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = usuarios;
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
