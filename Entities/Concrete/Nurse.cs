using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Nurse:IEntity
    {
        public int NurseId { get; set; }
        public string NurseName { get; set; }
        public DateTime NurseBirthday { get; set; }
        public DateTime NurseEntryDate { get; set; }
        public string NurseBirthCity { get; set; }
        public string NurseCaresWho { get; set; }
    }
}
