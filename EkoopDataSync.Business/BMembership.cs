using EkoopDataSync.Data.Dao;
using System;
using System.Collections.Generic;
using EkoopDataSync.Data.Interfaces;
using EkoopDataSync.Data.Repositories;
using EkoopDataSync.Model;
using EkoopDataSync.service.Interfaces;

namespace EkoopDataSync.Business
{
    public class BMembership : IMembership
    {
        private static readonly IMembershipDao Dao = new RMembership();

        public List<MMembership> RetrieveMembership =>
            Dao.RetrieveMembership;

        public MMembership Retrieve(Guid guid) =>
            Dao.Retrieve(guid);


        public int DeleteMembership(Guid guid) =>
            Dao.DeleteMembership(guid);

        public object InsertMembership(MMembership data) =>
            Dao.InsertMembership(data);
    }
}
