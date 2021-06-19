using System;
using System.Collections.Generic;
using CyberThink.Model;
using GalaSoft.MvvmLight.Messaging;
namespace CyberThink.ViewModel
{
    public class NotesList_ViewModel
    {

        public List<Note> noteList { get; set; }
        
        public NotesList_ViewModel()
        {
            noteList = new List<Note>();
            this.RegisterMessages();
        }

        public void RegisterMessages()
        {
            Messenger.Default.Register<Note>(this, UpdateNoteList);
        }

        public void UpdateNoteList(Note note)
        {
            noteList.Add(note);
            this.test();
        }

        //THIS IS WHERE YOU LEFT OFF. 
        public void test()
        {
            int number = noteList.Count;
        }
    }
}
