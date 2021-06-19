//NOTE USING THIS REPO ANYMORE
using System;
using System.Collections.Generic;
using System.Linq;

using CyberThink.Model;

namespace CyberThink.Repository
{
    public class ModuleRepository
    {
        private List<Module> begginerModulesList;
        private List<Module> intermidiateModulesList;


        public void GenerateModules()
        {
            begginerModulesList = new List<Module>();
            begginerModulesList.Add(new Module() { moduleName = "Introduction to Security", moduleInformation = "Some information", isComplete = false });
            begginerModulesList.Add(new Module() { moduleName = "The needs of Security", moduleInformation = "Some information", isComplete = false });
            begginerModulesList.Add(new Module() { moduleName = "The impacts of Security", moduleInformation = "Some information", isComplete = false });
            begginerModulesList.Add(new Module() { moduleName = "Summary", moduleInformation = "Some information", isComplete = false });

            intermidiateModulesList = new List<Module>();
            intermidiateModulesList.Add(new Module() { moduleName = "ISO 2000", moduleInformation = "Some information" });
            intermidiateModulesList.Add(new Module() { moduleName = "Incident Response", moduleInformation = "Some information" });
            intermidiateModulesList.Add(new Module() { moduleName = "Malware analysis", moduleInformation = "Some information" });
            intermidiateModulesList.Add(new Module() { moduleName = "Penetration testing", moduleInformation = "Some information" });
        }


        public void MarkBeginnerModuleAsComplete(int moduleIndex)
        {
            begginerModulesList[moduleIndex].isComplete = true;
        }

        public void MarkIntermidiateModuleAsComplete(int ModuleIndex)
        {

        }
    }
}

       

