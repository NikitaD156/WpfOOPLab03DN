using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfOOPLab03DN
{
    internal class ClassNoteRemove : ClassListNote
    {
        public ClassNoteRemove(string text, string doctorname, string patientname, DateTime thedate) : base(text, doctorname, patientname, thedate)
        {

        }

        public static void NoteRemove(int i)
        {
               notes.RemoveAt(i - 1);   
        }
    
    }
}
