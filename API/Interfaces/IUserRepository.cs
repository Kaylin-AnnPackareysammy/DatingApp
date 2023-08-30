﻿using API.Entities;
using API.Helpers;

namespace API;

public interface IUserRepository
{
    void Update(AppUser user);
    Task<bool>  SaveAllAsync();
    Task<IEnumerable<AppUser>> GetUsersAsync();
    Task<AppUser> GetUserByIdAsync(int id);
    Task<AppUser> GetUserByNameAsync(string username);
    Task<PagedList<MemberDto>> GetMemberAsync(UserParams userParams);
    Task<MemberDto> GetMemberAsync(string username);
    Task GetUserByUsernameAsync(string username);
}
