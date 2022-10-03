namespace RentACar.Application.Features.Auths.Dtos
{
    using Core.Security.Entities;
    using Core.Security.JWT;

    public class RefreshedTokenDto
    {
        public AccessToken AccessToken { get; set; }
        public RefreshToken RefreshToken { get; set; }
    }
}
