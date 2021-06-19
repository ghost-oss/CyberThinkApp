using System;
using CyberThink.Model;
using GalaSoft.MvvmLight.Messaging;
using CyberThink.ViewModel;

namespace CyberThink.ViewModel
{
    public class CreateNote_ViewModel
    {
        private Note revisionNote;

        public CreateNote_ViewModel()
        {
            revisionNote = new Note();
        }


        public void CreateNote(string noteTitle, string note)
        {
            revisionNote.noteTitle = noteTitle;
            revisionNote.note = note;

            this.SaveNote();
        }

        public void SaveNote()
        {
            Messenger.Default.Send<Note>(revisionNote);
        }

    }
}
