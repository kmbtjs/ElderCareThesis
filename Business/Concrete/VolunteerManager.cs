using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class VolunteerManager : IVolunteerService
    {
        IVolunteerDal _volunteerDal;
        public VolunteerManager(IVolunteerDal volunteerDal)
        {
            _volunteerDal = volunteerDal;
        }
        public List<Volunteer> GetAll()
        {
            return _volunteerDal.GetAll();
        }
    }
}
