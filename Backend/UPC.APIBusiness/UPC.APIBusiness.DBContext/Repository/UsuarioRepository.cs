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
        public EntityUsuario GetUsuario(int id)
        {
            var Usuario = new EntityUsuario();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ObtenerUsuario";

                    var p = new DynamicParameters();
                    p.Add(name: "@IdUsuario", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    Usuario = db.Query<EntityUsuario>(
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

            return Usuario;
        }

        public List<EntityUsuario> GetUsuarios()
        {
            var Usuarios = new List<EntityUsuario>();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ListarUsuarios";
                    Usuarios = db.Query<EntityUsuario>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Usuarios;
        }
    }
}
