using System;
using System.Collections.Generic;
using CyberThink;
using CyberThink.Model;
using CoreServices;
using CyberThink.ViewModel;
using CyberThink.Repository;
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

        public Module_ViewModel()
        {
            this.GenerateModules();
        }

        public void GenerateModules()
        {
            _begginerModulesList = new List<Module>();
            _begginerModulesList.Add(new Module() { moduleName = "Introduction to Security", moduleInformation = "Some information", isComplete = false });
            _begginerModulesList.Add(new Module() { moduleName = "The needs of Security", moduleInformation = "Some information", isComplete = false });
            _begginerModulesList.Add(new Module() { moduleName = "The impacts of Security", moduleInformation = "Some information", isComplete = false });
            _begginerModulesList.Add(new Module() { moduleName = "Summary", moduleInformation = "Some information", isComplete = false });

            _intermidiateModulesList = new List<Module>();
            _intermidiateModulesList.Add(new Module() { moduleName = "ISO 2000", moduleInformation = "Some information" });
            _intermidiateModulesList.Add(new Module() { moduleName = "Incident Response", moduleInformation = "Some information" });
            _intermidiateModulesList.Add(new Module() { moduleName = "Malware analysis", moduleInformation = "Some information" });
            _intermidiateModulesList.Add(new Module() { moduleName = "Penetration testing", moduleInformation = "Some information" });
        }

        public void MarkModuleAsComplete(string course, int moduleIndex)
        {
            if (course == "beginnerTableView")
            {
                _begginerModulesList[moduleIndex].isComplete = true;
                Messenger.Default.Send<List<Module>>(message: _begginerModulesList, token: "beginnerModulesToken");
                //Sends a message to the subscribers (if any) whom have registered with the same generic type and token
            }
            else
            {
                _intermidiateModulesList[moduleIndex].isComplete = true;
                Messenger.Default.Send<List<Module>>(message: _intermidiateModulesList, token: "intermidiaryModulesToken");
                //Sends a message to the subscribers (if any) whom have registered with the same generic type and token

            }
            
        }



        
    }
}
