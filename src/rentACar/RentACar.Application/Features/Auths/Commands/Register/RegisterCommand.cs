namespace RentACar.Application.Features.Auths.Commands.Register
{
    using Core.Security.Dtos;
    using MediatR;
    using RentACar.Application.Features.Auths.Dtos;
    using RentACar.Application.Features.Auths.Rules;
    using RentACar.Application.Services.Repositories;
    using System;
    using System.Threading.Tasks;

    public class RegisterCommand : IRequest<RegisteredDto>
    {
        public UserForRegisterDto UserForRegisterDto { get; set; }
        public string IpAddress { get; set; }

        public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisteredDto>
        {
            private readonly AuthBusinessRules _authBusinessRules;
            private readonly IUserRepository _userRepository;
            public Task<RegisteredDto> Handle(RegisterCommand request, CancellationToken cancellationToken)
            {
                //
                throw new NotImplementedException();
            }
        }
    }
}