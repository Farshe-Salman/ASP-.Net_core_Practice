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
            var data = repo.Get();                                //Broadly Mapper Configuration
            var mapper=MapperConfig.GetMapper();
            return mapper.Map<List<CategoryDTO>>(data);
        }


        public CategoryDTO Get(int id)
        {
            return MapperConfig.GetMapper().Map<CategoryDTO>(repo.Get(id));   //Shortform Mapper Configuration
        }

        public bool Create(CategoryDTO c)
        {
            return repo.Create(MapperConfig.GetMapper().Map<Category>(c));
        }

        public bool Update(CategoryDTO c)
        {
            return repo.Update(MapperConfig.GetMapper().Map<Category>(c));
        }

        public bool Delete(int id) {
            return repo.Delete(id);
        }


    }
}
