using System;
using CyberThink.DatabaseConnection;
using CyberThink.Model;
using System.Collections.Generic;
using Akavache;
using System.Threading.Tasks;
using System.Reactive.Linq;
using CyberThink.Repository;

namespace CyberThink.Service
{
    public class CacheService
    {
        public CacheService()
        {
        }

        #region ModuleList Cache Methods

        public async Task<List<Module>> RetrieveModuleListFromCache(string moduleType)
        {

            List<Module> list = new List<Module>();

            try
            {

                list = await BlobCache.LocalMachine.GetObject<List<Module>>(moduleType);

                if (list == null || list.Count == 0)
                {
                    ModuleRepository moduleRepository = new ModuleRepository();
                    moduleRepository.GenerateModules();
                    list = moduleRepository.RetrieveModuleList(moduleType);


                    this.InsertModuleListForCache(list, moduleType);
                }



            }
            catch
            {
                ModuleRepository moduleRepository = new ModuleRepository();
                moduleRepository.GenerateModules();
                list = moduleRepository.RetrieveModuleList(moduleType);

                this.InsertModuleListForCache(list, moduleType);
            }

            return list; 
        }


        public void InsertModuleListForCache(List<Module> moduleList, string moduleType)
        {

            BlobCache.LocalMachine.InvalidateObject<List<Module>>(moduleType);

            BlobCache.LocalMachine.InsertObject(moduleType,moduleList);

        }

        #endregion

        #region NotesList Cache Methods

        public void InsertNotesListForCache(string notesKey, List<Note> notesList)
        {
            BlobCache.LocalMachine.InvalidateObject<List<Note>>(notesKey);

            BlobCache.LocalMachine.InsertObject(notesKey,notesList);
        }

        public async Task<List<Note>> RetrieveNotesListFromCache(string notesKey)
        {
            List<Note> notes = new List<Note>();

            try
            {
                notes = await BlobCache.LocalMachine.GetObject<List<Note>>(notesKey);

                if (notes == null)
                {
                    return notes;
                }

            }
            catch (Exception ex)
            {

            }

            return notes;
        }

        public void RemoveNoteFromCache()
        {
            BlobCache.LocalMachine.InvalidateAll();
        }




        #endregion

    }

}
