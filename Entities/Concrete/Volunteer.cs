using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Volunteer:IEntity
    {
        public int VolunteerId { get; set; }
        public string VolunteerName { get; set; }
        public DateTime VolunteerBirthday { get; set; }
        public DateTime VolunteerEntryDate { get; set; }
        public string VolunteerBirthCity { get; set; }
        public string VolunteerJob { get; set; }
        public string VolunteerResidence { get; set; }
    }
}
