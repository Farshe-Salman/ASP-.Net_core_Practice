using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repos;
using DAL.EF.Models;
using BLL.DTOs;
using DAL.EF.Models;
using AutoMapper;

namespace BLL.Services
{
    public class DepartmentService
    {
        DepartmentRepo repo;

        public DepartmentService(DepartmentRepo repo)
        {
            this.repo = repo;
        }

        public List<DepartmentDTO> All()
        {
            var data = repo.GetAll();
            var ret = MapperConfig.GetMapper().Map<List<DepartmentDTO>>(data);
            return ret;
        }
    }
}
