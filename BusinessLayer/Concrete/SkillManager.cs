using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class SkillManager : ISkillService
    {
        private ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void TAdd(Skill t)
        {
            _skillDal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Skill t)
        {
            throw new NotImplementedException();
        }

        public List<Skill> TGetList()
        {
            return _skillDal.GetList();
        }

        public Skill TGetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
