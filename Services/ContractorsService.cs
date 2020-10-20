using System;
using System.Collections.Generic;
using jobContractor.Models;
using jobContractor.Repositories;

namespace jobContractor.Services
{
  public class ContractorsService
  {
    private readonly ContractorsRepository _repo;
    public ContractorsService(ContractorsRepository repo)
    {
      _repo = repo;
    }
    internal IEnumerable<Contractor> Get()
    {
      return _repo.Get();
    }

    internal Contractor Get(int id)
    {
      var data = _repo.Get(id);
      if (data == null)
      {
        throw new Exception("Invalid Id");
      }
      return (Contractor)data;
    }

    internal Contractor Create(Contractor newContractor)
    {
      return _repo.Create(newContractor);
    }

    internal object Edit(Contractor updated)
    {
      var data = Get(updated.Id);
      updated.Name = updated.Name != null ? updated.Name : data.Name;
      updated.Address = updated.Address != null ? updated.Address : data.Address;
      updated.Skills = updated.Skills != null ? updated.Skills : data.Skills;
      return _repo.Edit(updated);
    }

    internal string Delete(int id)
    {
      var data = Get(id);
      _repo.Delete(id);
      return "Deleted Contractor";
    }
  }
}