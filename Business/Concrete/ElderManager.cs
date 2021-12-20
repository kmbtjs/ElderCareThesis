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
    public class ElderManager : IElderService
    {
        IElderDal _elderDal;
        public ElderManager(IElderDal elderDal)
        {
            _elderDal = elderDal;
        }
        public List<Elder> GetAll()
        {
            return _elderDal.GetAll();
        }
    }
}
