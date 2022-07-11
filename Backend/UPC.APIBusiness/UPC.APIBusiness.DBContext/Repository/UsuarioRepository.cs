using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using Dapper;
using DBEntity;

namespace DBContext
{
    public class UsuarioResponse   : BaseRepository, IUserRepository
    {

        public EntityBaseResponse Insert(EntityUsuario usuario)
        {
            var response = new EntityBaseResponse();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_InsertarUsuario";

                    var p = new DynamicParameters();
                    p.Add(name: "@IDUSUARIO", dbType: DbType.Int32, direction: ParameterDirection.Output);
                    p.Add(name: "@LOGINUSUARIO", value: usuario.LoginUsuario, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@PASSWORDUSUARIO", value: usuario.PasswordUsuario, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@IDPERFIL", value: usuario.IdPerfil, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add(name: "@NOMBRES", value: usuario.Nombre, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@APELLIDOPATERNO", value: usuario.ApellidoPaterno, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@APELLIDOMATERNO", value: usuario.ApellidoMaterno, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@DOCUMENTOIDENTIDAD", value: usuario.DocumentoIdentidad, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@USUARIOCREA", value: usuario.UsuarioCrea, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    object value = db.Query<EntityUsuario>(
                            sql: sql,
                            param: p,
                            commandType: CommandType.StoredProcedure
                        ).FirstOrDefault();

                    var idusuario = p.Get<int>("@IDUSUARIO");

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

        public EntityBaseResponse GetUsur(EntityUsuario usuario)
        {
            throw new NotImplementedException();
        }

        public EntityBaseResponse Login(EntityLogin login)
        {
            throw new NotImplementedException();
        }

        public object GetUsuario()
        {
            throw new NotImplementedException();
        }
    }

    internal class DynamicParameters
    {
        public DynamicParameters()
        {
        }

        internal void Add(string name, DbType dbType, ParameterDirection direction)
        {
            throw new NotImplementedException();
        }

        internal void Add(string name, string value, DbType dbType, ParameterDirection direction)
        {
            throw new NotImplementedException();
        }

        internal void Add(string name, int value, DbType dbType, ParameterDirection direction)
        {
            throw new NotImplementedException();
        }

        internal object Get<T>(string v)
        {
            throw new NotImplementedException();
        }
    }
}
