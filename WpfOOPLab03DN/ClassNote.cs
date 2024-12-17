using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WpfOOPLab03DN
{
    internal abstract class ClassNote
    {
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        private string doctorName;

        public string DoctorName
        {
            get { return doctorName; }
            set { doctorName = value; }
        }

        private string patientName;

        public string PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }


        private DateTime thedate;

        public DateTime TheDate
        {
            get { return thedate; }
            set { thedate = value; }
        }

        public ClassNote(string text,string doctorname,string patientname,DateTime thedate)
        {
            this.Text = text;
            this.DoctorName = doctorname;
            this.PatientName = patientname;
            this.TheDate = thedate;
        }

        public abstract string MessageNote(string messagenote);

        public virtual string OutPut(string OutPutValue) {return OutPutValue; }

    }
}
