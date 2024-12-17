using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfOOPLab03DN
{
    internal class ClassSortNote : ClassListNote
    {

        

        public ClassSortNote(string text, string doctorname, string patientname, DateTime thedate) : base(text, doctorname, patientname, thedate)
        {

        }

        public static void SortNote() 
        {

            notes.Sort();
            
            
        }
    
    }
}
