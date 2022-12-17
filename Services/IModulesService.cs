using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Devcamp.API.Models;

namespace Devcamp.API.Services
{
  public interface IModulesService
  {
    Task<Module> Create(ModuleDTO moduleDTO);
    Task<List<Module>> Get();
    Task<Module> GetById(int id);
  }
}