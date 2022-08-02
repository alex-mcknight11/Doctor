using System.Collections.Generic;
using System;

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

        // public static void OrderByDate()
        // {
        //     IEnumerable<Item> orderedItems = items.OrderBy(item => item.DueDate);
        // }

    }
}