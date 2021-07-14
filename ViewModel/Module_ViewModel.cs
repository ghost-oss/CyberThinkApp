using System;
using System.Collections.Generic;
using CyberThink;
using CyberThink.Model;
using CoreServices;
using CyberThink.ViewModel;
using CyberThink.Repository;
using System.Threading.Tasks;
using CyberThink.Service;
using GalaSoft.MvvmLight.Messaging;

namespace CyberThink.ViewModel
{
    public class Module_ViewModel
    {
        private List<Module> _begginerModulesList;

        public List<Module> beginnerModulesList
        {
            get
            {
                return _begginerModulesList;
            }
        }

        private List<Module> _intermidiateModulesList;

        public List<Module> intermidiateModulesList
        {
            get
            {
                return _intermidiateModulesList;
            }
        }

        private CacheService cacheService;

        public Module_ViewModel()
        {
            this.GenerateModules().ConfigureAwait(false);
        }

        public async Task GenerateModules()
        {
            cacheService = new CacheService();

            _begginerModulesList = new List<Module>();
            _begginerModulesList = await cacheService.RetrieveModuleListFromCache("BeginnerModules");

            _intermidiateModulesList = new List<Module>();
            _intermidiateModulesList = await cacheService.RetrieveModuleListFromCache("IntermidateModules");

        }

        public void MarkModuleAsComplete(string course, int moduleIndex)
        {
            if (course == "beginnerTableView")
            {
                _begginerModulesList[moduleIndex].isComplete = true;

                cacheService.InsertModuleListForCache(_begginerModulesList, "BeginnerModules");

                // Messenger.Default.Send<List<Module>>(message: _begginerModulesList, token: "beginnerModulesToken");
                //Sends a message to the subscribers (if any) whom have registered with the same generic type and token
            }
            else
            {
                _intermidiateModulesList[moduleIndex].isComplete = true;
                cacheService.InsertModuleListForCache(_intermidiateModulesList, "IntermidateModules");

                //Messenger.Default.Send<List<Module>>(message: _intermidiateModulesList, token: "intermidiaryModulesToken");
                //Sends a message to the subscribers (if any) whom have registered with the same generic type and token

            }
            
        }



        
    }
}
