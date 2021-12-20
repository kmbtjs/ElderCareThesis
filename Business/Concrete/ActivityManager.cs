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
    public class ActivityManager : IActivityService
    {
        IActivityDal _activityDal;
        public ActivityManager(IActivityDal activityDal)
        {
            _activityDal = activityDal;
        }
        public List<Activity> GetAll()
        {
            return _activityDal.GetAll();
        }
    }
}
