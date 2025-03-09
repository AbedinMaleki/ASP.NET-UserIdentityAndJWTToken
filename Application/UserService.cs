using Infrastructure.Data;
using Infrastructure.Models;
using Infrastructure.Repository;
using Infrastructure.UnitOfWork;

namespace Application;

public class UserService
{
    private readonly Sample2DB _db;
    private readonly IUnitOfWork unitOfWork;

    public UserService(Sample2DB db,IUnitOfWork unitOfWork)
    {
        this._db = db;
        this.unitOfWork = unitOfWork;
    }
    public async Task<int> AddService(Users user)
    {
       await unitOfWork.userRepository.CreateUSer(user);
        await unitOfWork.Save();
        return user.id;

    }
}
