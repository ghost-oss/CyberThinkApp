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
using System.Threading.Tasks;

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

        public List<Module> RetrieveModule (string moduleType)
        {
            List<Module> moduleList = new List<Module>();

            try
            {
                var response = firebaseClient.Get("ModulesList/" + moduleType);

                moduleList = response.ResultAs<List<Module>>();


                //Add precaution such that checks if list is null and ensure all modules have valid information else remove from list (or display message)
                //Require error handler if there is no internet connection

                //if (moduleList != null)
                //{

                //}
                //else
                //{
                //    foreach (module)
                //    {

                //    }
                //}



            }
            catch (Exception ex)
            {
                var error = ex.GetType();
                var message = ex.Message;

            }



            return moduleList;
        }
    }

}


//var module = firebaseClient.Get("ModulesList/BeginnerModules/Introduction CS").ResultAs<Module>();