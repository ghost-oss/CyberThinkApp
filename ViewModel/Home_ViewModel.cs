using System;
using GalaSoft.MvvmLight;
using CyberThink.Model;
using System.Collections.Generic;
using GalaSoft.MvvmLight.Messaging;

namespace CyberThink.ViewModel
{
    public class Home_ViewModel 
    {

        public List<Module> beginnerModules;
        public List<Module> intermidiaryModules;

        public Home_ViewModel()
        {
            beginnerModules = new List<Module>();
            intermidiaryModules = new List<Module>();
            this.RegisterMessages();      
        }

        public void RegisterMessages()
        {
             //Subscribing the type of message we want to listen and recieve from the publisher
             //The message we're subscribing to will be of type List<Modules> and we have applied a distinctive token for the two messages.
             Messenger.Default.Register<List<Module>>(recipient: this, token: "beginnerModulesToken", UpdateBeginnerModuleList);
             Messenger.Default.Register<List<Module>>(recipient: this, token: "intermidiaryModulesToken", UpdateIntermidiaryModuleList); 
        }


        public void UpdateBeginnerModuleList(List<Module> list)
        {
            beginnerModules = list;
        }

        public void UpdateIntermidiaryModuleList(List<Module> list)
        {
            intermidiaryModules = list;
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
