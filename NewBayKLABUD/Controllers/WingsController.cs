using ModelsNewBayKLABUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WingRepositoryKLABUD;

namespace NewBayKLABUD.Controllers
{
    public class WingsController : ApiController
    {
        private readonly IWingDB _wingDB;

        public WingsController(IWingDB wingDB)
        {
            _wingDB = wingDB;
        }

        public List<Wing> Get()
        {
            return _wingDB.GetAll();
        }

        public Wing Get(int id)
        {
            return _wingDB.Get(id);
        }

        public int Post([FromBody] Wing wing)
        {
            return _wingDB.Create(wing);
        }

        public Wing Put([FromBody] Wing wing, int id)
        {
            wing.Id = id;
            return _wingDB.Update(wing);
        }

        public void Delete(int id)
        {
            _wingDB.Delete(id);
        }
    }
}
