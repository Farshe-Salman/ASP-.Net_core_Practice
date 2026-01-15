using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs;
using BLL.Jwt;
using DAL.EF.Models;
using DAL.Repos;
using System.Security.Cryptography;
using BCrypt.Net;

namespace BLL.Services
{
    public class AuthService
    {
        UserRepo repo;
        JwtService jwt;

        public AuthService(UserRepo repo, JwtService jwt)
        {
            this.repo = repo;
            this.jwt = jwt;
        }

        public bool Register(RegisterDTO dto)
        {
            var user = new User
            {
                Username = dto.Username,
                Password = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                Role = dto.Role,
                Email = dto.Email
            };
            return repo.Create(user);
        }

        public string Login(LoginDTO dto)
        {
            var user = repo.Get(dto.Username);
            if (user == null) return null;

            if (!BCrypt.Net.BCrypt.Verify(dto.Password, user.Password)) 
                return null;

            return jwt.GenerateToken(user.Username, user.Role);
        }
    }
}

