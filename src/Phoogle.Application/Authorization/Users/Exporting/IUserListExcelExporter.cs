using System.Collections.Generic;
using Phoogle.Authorization.Users.Dto;
using Phoogle.Dto;

namespace Phoogle.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}