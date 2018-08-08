using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SPA.PhoneBook.Roles.Dto;
using SPA.PhoneBook.Users.Dto;

namespace SPA.PhoneBook.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
