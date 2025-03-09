using Infrastructure.Data;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Sample2DB _db;
        public IUserRepository userRepository { get; }


        public UnitOfWork(Sample2DB db,IUserRepository user)
        {
            this._db = db;
            userRepository = user;
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task<int> Save()
        {
           return  await _db.SaveChangesAsync();
        }
    }
}
