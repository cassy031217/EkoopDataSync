using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EkoopDataSync.Model;

namespace EkoopDataSync.Data.Interfaces
{
    public interface IClientele
    {
        List<MClientele> RetrieveClientele { get; }
        MClientele Retrieve(Guid guid);
        int DeleteClientele(Guid guid);
        object InsertClientele(MClientele data);
    }
}
