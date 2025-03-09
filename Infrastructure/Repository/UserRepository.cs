using Infrastructure.Data;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly Sample2DB _db;

        public UserRepository(Sample2DB db)
        {
            this._db = db;
        }
        public async Task CreateUSer(Users user)
        {

                await _db.Users.AddAsync(user);

        }

        public async Task<List<Users>> GetAll()
        {
            return await  _db.Users.ToListAsync();
        }
    }
}
