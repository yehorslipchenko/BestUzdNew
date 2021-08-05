
namespace BestUzdNew.Api.Dtos.Input
{
    public class UserInDto
    {
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public UserInformationInDto UserInfo { get; set; }
    }
}
