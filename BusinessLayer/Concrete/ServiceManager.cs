using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TAdd(Service t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Service t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Service t)
        {
            throw new NotImplementedException();
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public Service TGetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
