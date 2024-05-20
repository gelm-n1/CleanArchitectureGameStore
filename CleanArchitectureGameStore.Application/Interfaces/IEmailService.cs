using CleanArchitectureGameStore.Application.Dto.Email;

namespace CleanArchitectureGameStore.Application.Interfaces;

public interface IEmailService
{
    Task SendAsync(EmailRequestDto request);
}