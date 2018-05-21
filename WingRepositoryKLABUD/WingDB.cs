using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using ModelsNewBayKLABUD;

namespace WingRepositoryKLABUD
{
    public class WingDB : IWingDB
    {
        private readonly string _connectionString = @"C:\DB\SOA_WINGS";
        private readonly string _collectionName = "wings";

        public int Create(Wing wing)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Wing>(_collectionName);

                return collection.Insert(wing);
            }
        }

        public void Delete(int id)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Wing>(_collectionName);

                collection.Delete(e => e.Id == id);
            }
        }

        public Wing Get(int id)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Wing>(_collectionName);

                return collection.FindById(id);
            }
        }

        public List<Wing> GetAll()
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Wing>(_collectionName);

                return collection.FindAll().ToList();
            }
        }

        public Wing Update(Wing wing)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Wing>(_collectionName);

                collection.Update(wing);
                return collection.FindById(wing.Id);
            }
        }
    }
}
