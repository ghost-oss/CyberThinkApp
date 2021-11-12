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
        private List<Module> _phishingModulesList;

        public List<Module> phishingModulesList
        {
            get
            {
                return _phishingModulesList;
            }
        }

        private List<Module> _passwordModulesList;

        public List<Module> passwordModulesList
        {
            get
            {
                return _passwordModulesList;
            }
        }

        private List<Module> _physicalModulesList;

        public List<Module> physicalModulesList
        {
            get
            {
                return _physicalModulesList;
            }
        }

        private CacheService cacheService;

        public Module_ViewModel()
        {
            //this.GenerateModules().ConfigureAwait(false);
            Task.Run(() => this.GenerateModules()).GetAwaiter().GetResult();
        }

        public async Task GenerateModules()
        {
            cacheService = new CacheService();

            _phishingModulesList = new List<Module>();
            _phishingModulesList = await cacheService.RetrieveModuleListFromCache("PhishingModules");

            _passwordModulesList = new List<Module>();
            _passwordModulesList = await cacheService.RetrieveModuleListFromCache("PasswordModules");


            _physicalModulesList = new List<Module>();
            _physicalModulesList = await cacheService.RetrieveModuleListFromCache("PhysicalModules");
        }

        public void MarkModuleAsComplete(string course, int moduleIndex)
        {
            if (course == "phishingModulesTableView")
            {
                _phishingModulesList[moduleIndex].isComplete = true;
                cacheService.InsertModuleListForCache(_phishingModulesList, "PhishingModules");

                // Messenger.Default.Send<List<Module>>(message: _begginerModulesList, token: "beginnerModulesToken");
                //Sends a message to the subscribers (if any) whom have registered with the same generic type and token
            }
            else if (course == "passwordModulesTableView")
            {
                _passwordModulesList[moduleIndex].isComplete = true;
                cacheService.InsertModuleListForCache(_passwordModulesList, "PasswordModules");

                //Messenger.Default.Send<List<Module>>(message: _intermidiateModulesList, token: "intermidiaryModulesToken");
                //Sends a message to the subscribers (if any) whom have registered with the same generic type and token

            }
            else
            {
                _physicalModulesList[moduleIndex].isComplete = true;
                cacheService.InsertModuleListForCache(_physicalModulesList, "PhysicalModules");
            }
            
        }



        
    }
}
