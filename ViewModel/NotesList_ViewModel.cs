using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using CyberThink.Model;
using GalaSoft.MvvmLight.Messaging;
using CyberThink.Service;
namespace CyberThink.ViewModel
{
    public class NotesList_ViewModel
    {

        public List<Note> noteList { get; set; }
        private CacheService cacheService;

        public NotesList_ViewModel()
        {
            
            noteList = new List<Note>();
            cacheService = new CacheService();
    
            Task.Run(() => this.RetrieveNotesListFromCache()).GetAwaiter().GetResult();
            this.RegisterMessages();
        }

        public void RegisterMessages()
        {
            Messenger.Default.Register<Note>(this, UpdateNoteList);
        }

        public void UpdateNoteList(Note note)
        {
            noteList.Add(note);
            this.InsertUpdatedNotesListForCache();
        }

        public void InsertUpdatedNotesListForCache()
        {
            cacheService.InsertNotesListForCache("revisionNotes", this.noteList);
        }

        public async Task RetrieveNotesListFromCache()
        {
            noteList = await cacheService.RetrieveNotesListFromCache("revisionNotes");
        }

    }
}
