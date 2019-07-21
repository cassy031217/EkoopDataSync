using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using EkoopDataSync.Data.Dao;
using EkoopDataSync.Model;

namespace EkoopDataSync.Data.Repositories
{
    public class RClientele: IClienteleDao
    {
        public List<MClientele> RetrieveClientele
        {
            get
            {
                const string sql = "select * from Clientele";
                return SqlHelper.MasterConnection.Query<MClientele>(sql).ToList();
            }
        }

        public MClientele Retrieve(Guid guid)
        {
            const string sql = "select * from Clientele where guid = @guid";
            return SqlHelper.MasterConnection.Query<MClientele>(sql, new { Guid = guid }).FirstOrDefault();
        }

        public int DeleteClientele(Guid guid)
        {
            const string sql = @"";
            return SqlHelper.MasterConnection.Execute(sql, new { Guid = guid });
        }

        public object InsertClientele(MClientele data)
        {
            const string sql = @"";
            return SqlHelper.MasterConnection.Execute(sql, data);
        }
    }
}
