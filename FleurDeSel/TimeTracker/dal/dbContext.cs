using LiteDB;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pointeuse
{
    public class dbContext
    {
        public string databaseFilePath { get; set; }
        private LiteRepository _repo;

        public dbContext(string databasePath)
        {
            this.databaseFilePath = databasePath;
            this._repo = new LiteRepository(this.databaseFilePath);
                      
        }
        public T GetDataById<T>(int id)
        {
            string CollectionName = typeof(T).Name;            
            return _repo.Query<T>(CollectionName).SingleById(id);
        }
        public List<string> GetDataBaseNames()
        {
            List<string> _ret = new List<string>();
            _ret = _repo.Database.GetCollectionNames().ToList<string>();
            return _ret;
        }
        public List<T> GetData<T>()
        {
            string CollectionName = typeof(T).Name;
            List<T> _ret = new List<T>();
            _ret = _repo.Query<T>(CollectionName).ToList();
            return _ret;
        }
        
        private bool IsJtokenIsNullOrEmpty(JToken token)
        {
            return (token == null) ||
                   (token.Type == JTokenType.Array && !token.HasValues) ||
                   (token.Type == JTokenType.Object && !token.HasValues) ||
                   (token.Type == JTokenType.String && token.ToString() == String.Empty) ||
                   (token.Type == JTokenType.Null);
        }


      
        public int Insert<T>(List<T> Data)
        {
            string CollectionName = typeof(T).Name;
            int _ret = -1;
            _ret = _repo.Insert<T>(Data, CollectionName);

            return _ret;
        }
        public int Upsert<T>(List<T> Data)
        {
            string CollectionName = typeof(T).Name;
            int _ret = -1;
            _ret = _repo.Upsert<T>(Data, CollectionName);
            return _ret;
        }
        public bool Upsert<T>(T Data)
        {
            string CollectionName = typeof(T).Name;
            bool _ret = false;
            _ret = _repo.Upsert<T>(Data, CollectionName);
            return _ret;
        }
        public int Update<T>(List<T> Data)
        {
            string CollectionName = typeof(T).Name;
            int _ret = -1;
            _ret = _repo.Update<T>(Data, CollectionName);
            return _ret;
        }
        public bool Update<T>(T Data)
        {
            string CollectionName = typeof(T).Name;
            bool _ret = false;
            _ret = _repo.Update<T>(Data, CollectionName);
            return _ret;
        }

        public int Delete<T>(List<T> ListEntity)
        {
            int _Iret = 0;
            foreach (T EntityItem in ListEntity)
            {
                string sID = EntityItem.GetType().GetProperty("id").GetValue(EntityItem).ToString();
                int iID = Convert.ToInt32(sID);
                bool _ret = this._repo.Delete<T>(iID);
                if (_ret)
                {
                    _Iret++;
                }
            }
            return _Iret;
        }
        public bool Delete<T>(T EntityItem)
        {
            string sID = EntityItem.GetType().GetProperty("id").GetValue(EntityItem).ToString();
            int iID = Convert.ToInt32(sID);
            bool _ret = this._repo.Delete<T>(iID);
            return _ret;
        }

        public bool Delete<T>(int id)
        {
            bool _ret = false;
            BsonValue bsID = (BsonValue)id;
            _ret = _repo.Delete<T>(id);

            return _ret;

        }

    }
}