using App.BusinessLayer.Dtos;
using App.DataAccessLayer.Data;
using AutoMapper;

namespace App.BusinessLayer.Services
{
    public class UserService
    {
        private readonly IMapper mapper;
        private readonly AppDbContext _db;

        public UserService(IMapper mapper, AppDbContext db)
        {
            this.mapper = mapper;
            _db = db;
        }

        public async Task<UserDto> CreateUser(UserDto user)
        {
            var userCheck = _db.Users.FirstOrDefault(e =>
                e.UserName == user.UserName || e.Email == user.Email);

            var userRegister = mapper.Map<User>(user);

            userRegister.UserName = user.UserName;
            userRegister.Name = user.UserName;
            userRegister.Email = user.Email;
            userRegister.IsActive = false;
            userRegister.Password = user.Password;
            userRegister.Roles = "User";
            userRegister.ProfileImagePath = "https://cdn.discordapp.com/attachments/916029512884563999/949102276654538792/user.png";

            _db.Users.Add(userRegister);
            _db.SaveChanges();

            return user;
        }
    }
}