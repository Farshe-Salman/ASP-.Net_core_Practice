using BLL.DTOs;
using DAL.EF.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CategoryService
    {
        CategoryRepo repo;

        public CategoryService(CategoryRepo repo)
        {
            this.repo = repo;
        }

        public List<CategoryDTO> Get()
        {
            var data = repo.Get();
            var mapper = MapperConfig.GetMapper();
            var ret = mapper.Map<List<CategoryDTO>>(data);
            return ret;
        }

        public CategoryDTO Get(int id) {
            var data = repo.Get(id);
            return MapperConfig.GetMapper().Map<CategoryDTO>(data); 
        }

        public bool Create(CategoryDTO c)
        {
            var mapper = MapperConfig.GetMapper();   // new line added
            var data = mapper.Map<DAL.EF.Models.CategoryService>(c);
            return repo.Create(data);

            //data=MapperConfig.GetMapper().Map<Category>(c);  // alternative line
            //return repo.Create(data);

            //return repo.Create(MapperConfig.GetMapper().Map<Category>(c));    //
        }

        public bool Update(CategoryDTO c)
        {
            var mapper = MapperConfig.GetMapper();   // new line added
            var data = mapper.Map<DAL.EF.Models.CategoryService>(c);
            return repo.Update(data);

            //data=MapperConfig.GetMapper().Map<Category>(c);  // alternative line
            //return repo.Create(data);

            //return repo.Create(MapperConfig.GetMapper().Map<Category>(c));    //
        }

        public bool Delete(int id)
        {
            return repo.Delete(id);
        }

    }

}
