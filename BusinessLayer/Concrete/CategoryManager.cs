using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal icategorydal)
        {
            _categorydal = icategorydal;
        }

        public Category TGetById(int id)
        {
            return _categorydal.GetByID(id);
        }

        public List<Category> GetList()
        {
            return _categorydal.GetListAll();
        }

        public void TAdd(Category t)
        {
            _categorydal.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categorydal.Delete(t);
        }

        public void TUpdate(Category t)
        {
            _categorydal.Update(t);
        }
    }
}
