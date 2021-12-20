using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Elder:IEntity
    {
        public int ElderId { get; set; }
        public string ElderName { get; set; }
        public DateTime ElderBirthday { get; set; }
        public DateTime ElderEntryDate { get; set; }
        public string ElderBirthCity { get; set; }
        public string ElderLivedCities { get; set; }
        public string ElderHobbies { get; set; }
        public string ElderInfo { get; set; }
    }
}
