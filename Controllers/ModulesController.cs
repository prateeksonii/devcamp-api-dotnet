using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Devcamp.API.Models;
using Devcamp.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Devcamp.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ModulesController : ControllerBase
  {

    private readonly IModulesService _modulesService;

    public ModulesController(IModulesService modulesService)
    {
      _modulesService = modulesService;
    }

    [HttpPost]
    async public Task<IActionResult> Create(ModuleDTO moduleDTO)
    {
      var module = await _modulesService.Create(moduleDTO);
      return CreatedAtAction(nameof(Create), new { Id = module.Id }, module);
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var modules = await _modulesService.Get();
      return new OkObjectResult(modules);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      var module = await _modulesService.GetById(id);
      if (module == null)
      {
        return NotFound();
      }

      return new OkObjectResult(module);
    }
  }
}