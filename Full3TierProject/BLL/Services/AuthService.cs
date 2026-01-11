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
using System.Text;

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

        string Hash(string input)
        {
            using var sha = SHA256.Create();
            return Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(input)));
        }

        public bool Register(RegisterDTO dto)
        {
            var user = new User
            {
                Username = dto.Username,
                Password = Hash(dto.Password)
            };
            return repo.Create(user);
        }

        public string Login(LoginDTO dto)
        {
            var user = repo.Get(dto.Username);
            if (user == null) return null;

            if (user.Password != Hash(dto.Password)) return null;

            return jwt.GenerateToken(user.Username);
        }
    }
}

