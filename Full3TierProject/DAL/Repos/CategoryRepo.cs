using DAL.EF;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CategoryRepo
    {
        PMSContext Db;
        public CategoryRepo(PMSContext db)
        {
            Db = db;
        }

        public bool Create(CategoryService c)
        {
            Db.Categories.Add(c);
            return Db.SaveChanges() > 0;
        }

        public List<CategoryService> Get()
        {
            return Db.Categories.ToList();
        }

        public CategoryService Get(int id)
        {
            return Db.Categories.Find(id);
        }

        public bool Update(CategoryService c)
        {
            var ex= Get(c.Id);
            Db.Entry(ex).CurrentValues.SetValues(c);
            return Db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex= Get(id);
            Db.Categories.Remove(ex);
            return Db.SaveChanges()>0;

        }

        
    }
}
