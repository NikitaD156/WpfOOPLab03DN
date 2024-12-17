using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfOOPLab03DN
{
    internal class ClassInPut : ClassNote
    {
        public ClassInPut(string text, string doctorname, string patientname, DateTime thedate) : base(text,doctorname,patientname, thedate)
        {
            ClassListNote.notes.Add(new ClassListNote(this.Text,this.DoctorName,this.PatientName, (DateTime)this.TheDate));
        }

        public override string MessageNote(string messagenote) { return messagenote; }

    }
}
