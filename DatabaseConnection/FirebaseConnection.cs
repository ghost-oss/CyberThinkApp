/*
 * FB connection - sahildeveloper6@gmail.com / CApricorn5! 
 * 
 * 
 */
using System;
using CyberThink.Model;
using System.Collections.Generic;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace CyberThink.DatabaseConnection
{
    public class FirebaseConnection
    {

        public List<Module> beginnerModules;
        private IFirebaseClient firebaseClient;
        private IFirebaseConfig firebaseConfig;



        public FirebaseConnection()
        {
            
        }

        public void CreateConnection()
        {
            try
            {
                firebaseConfig = new FirebaseConfig()
                {
                    AuthSecret = "brdap1oxOz9NTg73fWBCDqzin6XxBLumQ6M6sIFl",
                    BasePath = "https://cyberthink-dabb4-default-rtdb.firebaseio.com/"
                };

                firebaseClient = new FireSharp.FirebaseClient(firebaseConfig);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void InsertData()
        {
            Module module1 = new Module()
            {
                moduleName = "introduction",
                moduleInformation = "This is an introductory module",
                isComplete = false,
                moduleId = 1
            };

            firebaseClient.Set("ModuleList/" + module1.moduleId, module1);

            //public List<Module> SelectModule(string moduleType)
            //{


            //}
        }
    }

}
