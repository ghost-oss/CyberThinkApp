using System;
using CyberThink.Service;
using GalaSoft.MvvmLight;
using CyberThink.Model;
using System.Collections.Generic;
using GalaSoft.MvvmLight.Messaging;
using System.Threading.Tasks;

namespace CyberThink.ViewModel
{
    public class Home_ViewModel 
    {

        public List<Module> beginnerModules;
        public List<Module> intermidiaryModules;
        public CacheService cacheService;


        public Home_ViewModel()
        {
            beginnerModules = new List<Module>();
            intermidiaryModules = new List<Module>();
            cacheService = new CacheService();


        }

        public void RetrieveUpdatedModules()
        {
            //Runs an async task and halts main thread until operation is complete. This prevents loading of progress bar before getting completion results
            Task.Run(() => RetrieveModules()).GetAwaiter().GetResult();
        }

        public async Task RetrieveModules()
        {

            beginnerModules = await cacheService.RetrieveModuleListFromCache("BeginnerModules");
            //beginnerModules = cacheService.RetrieveModulesNonAsync("BeginnerModules");

            intermidiaryModules = await cacheService.RetrieveModuleListFromCache("IntermidateModules");
            //intermidiaryModules = cacheService.RetrieveModulesNonAsync("IntermidateModules");

        }


        //Returns total percentage completion of the parsed moduleList i.e beginner, intermidiate and advanced from the Home_VC
        public float ReturnModuleTotalCompletionValue(List<Module> moduleList)
        {
            float completedModules = 0;

            foreach (var module in moduleList)
            {
                if (module.isComplete == true)
                {
                    completedModules += 1;
                }
            }

            if (completedModules != 0)
            {
                return (completedModules / moduleList.Count) * 100;
            }
            else
            {
                return 0;
            }

        }


    }
}


/*
       

         public void RegisterMessages()
        {
             //Subscribing the type of message we want to listen and recieve from the publisher
             //The message we're subscribing to will be of type List<Modules> and we have applied a distinctive token for the two messages.
             Messenger.Default.Register<List<Module>>(recipient: this, token: "beginnerModulesToken", UpdateBeginnerModuleList);
             Messenger.Default.Register<List<Module>>(recipient: this, token: "intermidiaryModulesToken", UpdateIntermidiaryModuleList); 
        }

 */