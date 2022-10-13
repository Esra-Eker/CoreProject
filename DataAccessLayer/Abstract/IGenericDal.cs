using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class  // T bi classa ait bütün değerleri üzerine alabilir.
    {
        void Insert(T t); // Ekleme işlemini yapabilmesi için entityden bi p parametresi alması gerek.
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetByID(int id);
    }
}
