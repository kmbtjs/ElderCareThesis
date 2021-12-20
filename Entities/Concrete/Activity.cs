using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Activity:IEntity
    {
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string ActivityStatus { get; set; }
        public DateTime ActivityDate { get; set; }
        public string ActivityInfo { get; set; }
        public string ActivityParticipants { get; set; }
    }
}
