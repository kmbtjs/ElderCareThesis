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
    public class NurseManager : INurseService
    {
        INurseDal _nurseDal;
        public NurseManager(INurseDal nurseDal)
        {
            _nurseDal = nurseDal;
        }
        public List<Nurse> GetAll()
        {
            return _nurseDal.GetAll();
        }
    }
}
