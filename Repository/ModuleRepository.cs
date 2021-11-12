//NOTE USING THIS REPO ANYMORE
using System;
using System.Collections.Generic;
using System.Linq;

using CyberThink.Model;

namespace CyberThink.Repository
{
    public class ModuleRepository
    {
        private List<Module> phishingModulesList;
        private List<Module> passwordeModulesList;
        private List<Module> physicalModulesList;


        public void GenerateModules()
        {
            phishingModulesList = new List<Module>();
            phishingModulesList.Add(new Module() { moduleName = "Topic 1", moduleInformation = "Some information", isComplete = false });
            phishingModulesList.Add(new Module() { moduleName = "Topic 2", moduleInformation = "Some information", isComplete = false });
            phishingModulesList.Add(new Module() { moduleName = "Topic 3", moduleInformation = "Some information", isComplete = false });

            passwordeModulesList = new List<Module>();
            passwordeModulesList.Add(new Module() { moduleName = "Topic 1", moduleInformation = "Some information", isComplete = false });
            passwordeModulesList.Add(new Module() { moduleName = "Topic 2", moduleInformation = "Some information", isComplete = false });
            passwordeModulesList.Add(new Module() { moduleName = "Topic 3", moduleInformation = "Some information", isComplete = false });

            physicalModulesList = new List<Module>();
            physicalModulesList.Add(new Module() { moduleName = "Topic 1", moduleInformation = "Some information", isComplete = false });
            physicalModulesList.Add(new Module() { moduleName = "Topic 2", moduleInformation = "Some information", isComplete = false });
            physicalModulesList.Add(new Module() { moduleName = "Topic 3", moduleInformation = "Some information", isComplete = false });
        }


        public List<Module> RetrieveModuleList(string moduleType)
        {
            if (moduleType == "PhishingModules")
            {
                return phishingModulesList;
            }
            else if (moduleType == "PasswordModules")
            {
                return passwordeModulesList;
            }
            else
            {
                return physicalModulesList;
            }
        }
    }
}

       

