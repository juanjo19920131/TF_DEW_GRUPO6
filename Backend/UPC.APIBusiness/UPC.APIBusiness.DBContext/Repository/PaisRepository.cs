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
        public List<EntityPais> GetPais()
        {
            throw new NotImplementedException();
        }

        public EntityPais GetPais(string CodPais)
        {
            var pais = new EntityPais();

            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = "usp_ListarPaises";
                }
            }
            catch (Exception ex)
            {

            }

            return pais;
        }
    }
}
