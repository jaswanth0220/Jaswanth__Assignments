﻿using HandsOnApiUsingEntityFrameWork.Entities;

namespace HandsOnApiUsingEntityFrameWork.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ECommContext _context;
        private IConfiguration _configuration;
        public UserRepository(ECommContext context)
        {
            _context = context;
        }

        public UserRepository(ECommContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        //public UserRepository()
        //{
        //    _context = new ECommContext();
        //}
        public void Register(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User ValidUser(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u=>u.Email==email && u.Password==password);
            return user;
        }

    }
}
