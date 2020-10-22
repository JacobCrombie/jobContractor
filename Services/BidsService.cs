using System;
using System.Collections.Generic;
using jobContractor.Models;
using jobContractor.Repositories;

namespace jobContractor.Services
{
  public class BidsService
  {
      private readonly BidsRepository _repo;

    public BidsService(BidsRepository repo)
    {
      _repo = repo;
    }
    internal Bid Get(int id)
    {
      Bid data = _repo.Get(id);
      if(data == null)
      {
          throw new Exception("Invalid Id");
      }
      return data;
    }

    internal Bid Create(Bid newBid)
    {
        return _repo.Create(newBid);
    }

    internal string Delete(int id)
    {
      var data = Get(id);
      _repo.Delete(id);
      return "Deleted Job";
    }

  }
}