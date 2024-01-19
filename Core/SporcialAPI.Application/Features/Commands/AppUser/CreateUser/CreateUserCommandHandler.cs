using MediatR;
using Microsoft.AspNetCore.Identity;

namespace SporcialAPI.Application.Features.Commands.AppUser.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly UserManager<Domain.Entities.Identity.AppUser> _userManager;
        
        public CreateUserCommandHandler(UserManager<Domain.Entities.Identity.AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<CreateUserCommandResponse> Handle (CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            IdentityResult result = await _userManager.CreateAsync(new() {
                Id = Guid.NewGuid().ToString(),
                Name = request.Name,
                Surname = request.Surname,
                Email = request.Email
            }, request.Password);

            CreateUserCommandResponse response = new() {Succeeded = result.Succeeded };

            if(result.Succeeded)
                response.Message = "Kullanıcı oluşturma Başarılı";
            else 
                response.Message = "Task Failed Successfully";

            return response;
        }
    }
}
