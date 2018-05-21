using ModelsNewBayKLABUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingRepositoryKLABUD
{
    public interface IWingDB
    {
        int Create(Wing wing);
        Wing Get(int id);
        List<Wing> GetAll();
        Wing Update(Wing wing);
        void Delete(int id);
    }
}
