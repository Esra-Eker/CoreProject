using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal  // IAboutDal ı burada inherit ediyorum çünkü ilerde bi entity için farklı bi metot oluşturmak isteyebilirim. bunu yapmak için metotun imzasını IAboutDalda atıcam, metotu da burada doldurucam.
    {

    }
}
