using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.EF.Models;
using System.Linq;

namespace DAL.Repos
{
    public class UserRepo
    {
        PMSContext db;

        public UserRepo(PMSContext db)
        {
            this.db = db;
        }

        public bool Create(User u)
        {
            db.Users.Add(u);
            return db.SaveChanges() > 0;
        }

        public User Get(string username)
        {
            return db.Users.FirstOrDefault(x => x.Username == username);
        }
    }
}

