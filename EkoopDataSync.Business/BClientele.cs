using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EkoopDataSync.Data.Dao;
using EkoopDataSync.Data.Interfaces;
using EkoopDataSync.Data.Repositories;
using EkoopDataSync.Model;

namespace EkoopDataSync.Business
{
    public class BClientele : IClientele
    {
        private static readonly IClienteleDao Dao = new RClientele();

        public List<MClientele> RetrieveClientele =>
            Dao.RetrieveClientele;

        public MClientele Retrieve(Guid guid) =>
            Dao.Retrieve(guid);


        public int DeleteClientele(Guid guid) =>
            Dao.DeleteClientele(guid);

        public object InsertClientele(MClientele data) =>
            Dao.InsertClientele(data);
    }
}
