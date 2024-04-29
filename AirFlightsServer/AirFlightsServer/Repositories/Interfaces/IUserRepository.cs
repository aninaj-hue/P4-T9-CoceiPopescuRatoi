﻿using System.Collections.Generic;
using System.Threading.Tasks;
using DataBaseLayout.Models;

namespace AirFlightsServer.Repositories.Interfaces;

public interface IUserRepository
{
    Task<List<User>> GetUsersAsync();
    Task AddUserAsync(User model);
    Task DeleteUserAsync(string CNP);
}