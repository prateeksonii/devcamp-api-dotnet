using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Devcamp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Devcamp.API.Services
{
  public class ModulesService : IModulesService
  {

    private DevcampDbContext _context;

    public ModulesService(DevcampDbContext context)
    {
      _context = context;
    }

    public async Task<Module> Create(ModuleDTO moduleDTO)
    {
      var module = new Module { Name = moduleDTO.Name };
      _context.Add(module);
      await _context.SaveChangesAsync();

      return module;
    }

    public async Task<List<Module>> Get()
    {
      var modules = await _context.Modules.ToListAsync();
      return modules;
    }

    public async Task<Module> GetById(int id)
    {
      var module = await _context.Modules.FindAsync(id);
      return module;
    }
  }
}