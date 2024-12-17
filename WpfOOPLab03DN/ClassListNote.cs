using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfOOPLab03DN
{
    internal class ClassListNote : ClassNote
    {
        public static List<ClassNote> notes = new List<ClassNote>();

        
        public ClassListNote(string text, string doctorname, string patientname, DateTime thedate) : base(text, doctorname, patientname, thedate)
        {
            this.Text = text;
            this.DoctorName = doctorname;
            this.PatientName = patientname;
            this.TheDate = thedate;

        }
        public override string MessageNote(string messagenote) { return messagenote; }
    }
}
