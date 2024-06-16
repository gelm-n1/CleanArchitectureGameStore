using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecureGameStore.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class ApiControllerBase : ControllerBase 
{
}