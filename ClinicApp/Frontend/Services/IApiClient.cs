using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicDTO;

namespace FrontEnd.Services
{
    public interface IApiClient
    {
        Task<List<User>> GetUsersAsync();
        Task<User> GetUserAsync(int id);
        Task<bool> AddUserAsync(User user);
    }
}