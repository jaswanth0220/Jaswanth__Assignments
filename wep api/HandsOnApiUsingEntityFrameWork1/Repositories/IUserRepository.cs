using HandsOnApiUsingEntityFrameWork.Entities;

namespace HandsOnApiUsingEntityFrameWork.Repositories
{
    public interface IUserRepository
    {
        void Register(User user);
        User ValidUser(string email, string password);
    }
}
