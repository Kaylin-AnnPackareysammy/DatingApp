﻿using API.Entities;

namespace API;

public interface IUserRepository
{
    void Update(AppUser user);
    Task<bool>  SaveAllAsync();
    Task<IEnumerable<AppUser>> GetUsersAsync();
    Task<AppUser> GetUserByIdAsync(int id);
    Task<AppUser> GetUserByNameAsync(string username);
    Task<IEnumerable<MemberDto>> GetMemberAsync();
    Task<MemberDto> GetMemberAsync(string username);

}