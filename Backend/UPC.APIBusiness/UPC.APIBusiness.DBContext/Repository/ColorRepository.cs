using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using Dapper;
using DBEntity;

namespace DBContext
{
    public class ColorRepository : BaseRepository, IColorRepository
    {
        public EntityColor GetColor(string codigo)
        {
            var Color = new EntityColor();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ObtenerColor";

                    var p = new DynamicParameters();
                    p.Add(name: "@CodColor", value: codigo, dbType: DbType.String, direction: ParameterDirection.Input);

                    Color = db.Query<EntityColor>(
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

            return Color;
        }

        public List<EntityColor> GetColores()
        {
            var Colores = new List<EntityColor>();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ListarColores";
                    Colores = db.Query<EntityColor>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Colores;
        }

        public List<EntityColor> GetColoresPorModelo(string codigo)
        {
            var Colores = new List<EntityColor>();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ListarColoresPorModelo";

                    var p = new DynamicParameters();
                    p.Add(name: "@CodColores", value: codigo, dbType: DbType.String, direction: ParameterDirection.Input);

                    Colores = db.Query<EntityColor>(
                        sql: sql,
                        param: p,
                        commandType: CommandType.StoredProcedure
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Colores;
        }
    }
}
