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
        if(data == null)
        {
            throw new Exception("Invalid Id");
        }
        return (Contractor)data;
    }

    internal object Create(Contractor newContractor)
    {
      throw new NotImplementedException();
    }
  }
}