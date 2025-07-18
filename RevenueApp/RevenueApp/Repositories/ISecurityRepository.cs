using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using RevenueApp.DTOs.Security;
using RevenueApp.Entities;
using RevenueApp.Entities.Configs;
using Microsoft.IdentityModel.Tokens;

namespace RevenueApp.Repositories;

public interface ISecurityRepository
{
    public Task<bool> UserExistsAsync(string login, CancellationToken token);
    public Task<Role?> GetRoleAsync(string roleName, CancellationToken token);

    public bool IsRoleInDb(Role? role);
    public AppUser? CreateNewAppUser(RegisterRequest request, Tuple<string, string> hash, int roleId);
    public Task<int> AddNewUserAsync(AppUser? user, CancellationToken token);
    
    
    public Task<AppUser?> GetUserAsync(string login, CancellationToken token);
    public SymmetricSecurityKey NewSymmetricSecurityKey();
    public SigningCredentials NewSigningCredentials(SymmetricSecurityKey key);
    public JwtSecurityToken NewJwtSecurityToken(Claim[] claims, SigningCredentials credentials);
    public Task<int> RefreshTokensAsync(AppUser user, CancellationToken token);
    public string Response(JwtSecurityToken token, AppUser user);


    public Task<AppUser?> GetUserAsyncByToken(string refreshToken, CancellationToken token);
    public bool IsRefreshTokenExpired(DateTime? date);
}