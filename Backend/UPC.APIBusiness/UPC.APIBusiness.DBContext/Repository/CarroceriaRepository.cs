using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using Dapper;
using DBEntity;

namespace DBContext
{
    public class CarroceriaRepository : BaseRepository, ICarroceriaRepository
    {
        public EntityBaseResponse GetCarroceria(int id)
        {
            var response = new EntityBaseResponse();

            try
            {
                using (var db = GetSqlConnection())
                {
                    var carroceria = new EntityCarroceria();
                    const string sql = "usp_ObtenerCarroceria";

                    var p = new DynamicParameters();
                    p.Add(name: "@IdCarroceria", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    carroceria = db.Query<EntityCarroceria>(
                        sql: sql,
                        param: p,
                        commandType: CommandType.StoredProcedure
                        ).FirstOrDefault();

                    if(carroceria != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = carroceria;
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

        public EntityBaseResponse GetCarrocerias()
        {
            var response = new EntityBaseResponse();

            try
            {
                using (var db = GetSqlConnection())
                {
                    var carrocerias = new List<EntityCarroceria>();
                    const string sql = "usp_ListarCarrocerias";

                    carrocerias = db.Query<EntityCarroceria>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();

                    if (carrocerias != null)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = carrocerias;
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
