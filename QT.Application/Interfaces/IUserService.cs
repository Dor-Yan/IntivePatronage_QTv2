using QT.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Application.Interfaces
{
   public interface IUserService
    {
        ListUserForListDto GetAllUsersForList();
        UserDetailsDto GetUserDetails(int userId);
    }
}
