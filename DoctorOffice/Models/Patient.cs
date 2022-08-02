using System.Collections.Generic;
using System;
using System.Linq; 
using System.Text;

namespace DoctorOffice.Models
{
    public class Patient
    {
        public Patient()
        {
            this.JoinEntities = new HashSet<DoctorPatient>();
        }

        public int PatientId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        // public bool Completed {get; set; }


        public virtual ICollection<DoctorPatient> JoinEntities { get;}

        public string Date() 
        {
            return this.BirthDate.ToString("yyyy-MM-dd");
        }
    }


}
