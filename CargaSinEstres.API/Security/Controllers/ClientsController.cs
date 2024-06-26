using AutoMapper;
using CargaSinEstres.API.Security.Domain.Models;
using CargaSinEstres.API.Security.Domain.Services;
using CargaSinEstres.API.Security.Domain.Services.Communication;
using CargaSinEstres.API.Security.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CargaSinEstres.API.Security.Controllers;

[Authorization.Attributes.Authorize]
[ApiController]
[Route("/api/v1/[controller]")]
public class ClientsController : ControllerBase{
    
    private readonly IClientService _clientService;
    private readonly IMapper _mapper;

    public ClientsController(IClientService clientService, IMapper mapper)
    {
        _clientService = clientService;
        _mapper = mapper;
    }

    [AllowAnonymous]
    [HttpPost("sign-in")]
    public async Task<IActionResult> AuthenticateClient(AuthenticateRequestClient request)
    {
        var response = await _clientService.AuthenticateClient(request);
        return Ok(response);
    }
    
   
    [AllowAnonymous]
    [HttpPost("sign-up")]
    public async Task<IActionResult> Register(RegisterRequestClient request)
    {
        await _clientService.RegisterClientAsync(request);
        return Ok(new { message = "Registration successful" });
    }
    
    
    [AllowAnonymous]
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var clients = await _clientService.ListClientAsync();
        var resources = _mapper.Map<IEnumerable<Client>,
            IEnumerable<ClientResource>>(clients);
        return Ok(resources);
    }
    
    
    [AllowAnonymous]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var client = await _clientService.GetByIdClientAsync(id);
        var resource = _mapper.Map<Client, ClientResource>(client);
        return Ok(resource);
    }
    
   
    [AllowAnonymous]
    [HttpPatch("{id}")]
    public async Task<IActionResult> UpdateClient(int id, UpdateRequestClient request)
    {
        await _clientService.UpdateClientAsync(id, request);
        return Ok(new { message = "Client updated successfully" });
    }
    
    //get for login
    
    
}