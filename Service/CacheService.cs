using System;
using CyberThink.DatabaseConnection;
using CyberThink.Model;
using System.Collections.Generic;
using Akavache;
using System.Reactive.Linq;

namespace CyberThink.Service
{
    public class CacheService
    {
        public CacheService()
        {
        }

        public List<Module> RetrieveModuleListFromCache(string moduleType)
        {

            List<Module> list = BlobCache.UserAccount.GetObject<List<Module>>(moduleType) as List<Module>;

            if (list == null)
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
            BlobCache.LocalMachine.InsertObject(moduleType,moduleList);
        }

        public void UpdateModuleStatus()
        {

        }
    }

    //public async void test()
    //{

    //    await BlobCache.UserAccount.InsertObject("modules", home_ViewModel.beginnerModules);
    //    // Or without async/await:
    //    //myRevisionNotes = await BlobCache.UserAccount.GetObject<revisionNotes>("revisionNotes").Catch(Observable.Return(new revisionNotes()));


     



    //}

}
