namespace Dashboard_webAPI.Models
{
    public interface IUserRepository
    {
        //CRUD
        Task<User> AddUser(User user);
        Task<User> FindUserById(int id);
        Task<User> UpdateUser(User user);
        Task<User> DeleteUserById(int id, User user);

    }
}
