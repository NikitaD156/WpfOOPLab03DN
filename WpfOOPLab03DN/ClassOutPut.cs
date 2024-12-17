using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfOOPLab03DN
{
    internal class ClassOutPut : ClassListNote
    {

        public ClassOutPut(string text, string doctorname, string patientname, DateTime thedate) : base(text, doctorname, patientname, thedate)
        {
        }

        public static string OutPut()
        {
            string OutPutValue = null;
            foreach (var note in notes)
            {
                 OutPutValue +=
                    notes.IndexOf(note) + 1 + ") " + note.Text + note.DoctorName + note.PatientName + " (" + note.TheDate.ToString("dd MMM HH") + ")\n";
            }
            return OutPutValue;
        }
    }
}
