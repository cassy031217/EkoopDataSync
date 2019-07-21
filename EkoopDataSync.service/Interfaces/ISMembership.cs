using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EkoopDataSync.Model;

namespace EkoopDataSync.service.Interfaces
{
    public interface ISMembership
    {
        List<MMembership> RetrieveMembership { get; }
        MMembership Retrieve(Guid id);
        object InsertMembership(MMembership mNotes);
        int DeleteMembership(Guid guid);
    }
}
