namespace RentACar.Application.Features.Auths.Rules
{
    using Core.CrossCuttingConcerns.Exceptions;
    using Core.Security.Entities;
    using RentACar.Application.Services.Repositories;
    using System.Threading.Tasks;

    public class AuthBusinessRules
    {
        private readonly IUserRepository _userRepository;

        public AuthBusinessRules(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task EmailCanNotBeDuplicatedWhenRegistered(string email)
        {
            User? user = await _userRepository.GetAsync(u => u.Email == email);
            if (user != null) throw new BusinessException("Mail already exists");

        }
    }
}
