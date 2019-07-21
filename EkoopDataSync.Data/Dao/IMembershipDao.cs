using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EkoopDataSync.Model;

namespace EkoopDataSync.Data.Dao
{
    public interface IMembershipDao
    {
        List<MMembership> RetrieveMembership { get; }
        MMembership Retrieve(Guid guid);
        object InsertMembership(MMembership data);
        int DeleteMembership(Guid guid);
    }
}
