using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using EkoopDataSync.Data.Dao;
using EkoopDataSync.Model;

namespace EkoopDataSync.Data.Repositories
{
    public class RMembership : IMembershipDao
    {
        public List<MMembership> RetrieveMembership
        {
            get
            {
                const string sql = "";
                return SqlHelper.MasterConnection.Query<MMembership>(sql).ToList();
            }
        }
        public MMembership Retrieve(Guid guid)
        {
            const string sql = "";
            return SqlHelper.MasterConnection.Query<MMembership>(sql, new { Guid = guid }).FirstOrDefault();
        }

        public object InsertMembership(MMembership data)
        {
            const string sql = @"";
            return SqlHelper.MasterConnection.Execute(sql, data);
        }

        public int DeleteMembership(Guid guid)
        {
            const string sql = @"";
            return SqlHelper.MasterConnection.Execute(sql, new { Guid = guid });
        }
    }
}
