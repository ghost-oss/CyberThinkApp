using System;
using CyberThink.DatabaseConnection;
using CyberThink.Model;
using System.Collections.Generic;
using Akavache;
using System.Threading.Tasks;
using System.Reactive.Linq;

namespace CyberThink.Service
{
    public class CacheService
    {
        public CacheService()
        {
        }

        #region ModuleList Cache Methods

        public async Task<List<Module>> RetrieveModuleListFromCache(string moduleType)
        {

            List<Module> list = new List<Module>();

            try 
            {

                list = await BlobCache.LocalMachine.GetObject<List<Module>>(moduleType);

                if (list == null || list.Count == 0)
                {
                    FirebaseConnection fbClient = new FirebaseConnection();
                    fbClient.CreateConnection();
                    list = fbClient.RetrieveModule(moduleType);
                    this.InsertModuleListForCache(list, moduleType);
                }

            }
            catch 
            {
                FirebaseConnection fbClient = new FirebaseConnection();
                fbClient.CreateConnection();
                list = fbClient.RetrieveModule(moduleType);
                this.InsertModuleListForCache(list, moduleType);
            }
       
            return list; 
        }


        public void InsertModuleListForCache(List<Module> moduleList, string moduleType)
        {

            BlobCache.LocalMachine.InvalidateObject<List<Module>>(moduleType);

            BlobCache.LocalMachine.InsertObject(moduleType,moduleList);

        }

        #endregion
    }

}
