using Exam.UserManager.Repository.Models;

namespace Exam.UserManager.Repository
{
    public interface IUserRepository
    {
        string Add(UserModel user);
        IEnumerable<UserModel> Get();
        IEnumerable<UserModel> GetAll();
        UserModel Get(string id);
        bool Update(UserModel user);


    }
}