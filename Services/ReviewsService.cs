using System;
using System.Collections.Generic;
using jobContractor.Models;
using jobContractor.Repositories;

namespace jobContractor.Services
{
  public class ReviewsService
  {
      private readonly ReviewsRepository _repo;

    public ReviewsService(ReviewsRepository repo)
    {
      _repo = repo;
    }

    internal IEnumerable<Review> Get()
    {
      return _repo.Get();
    }

    internal Review Get(int id)
    {
        Review data = _repo.Get(id);
        if (data == null)
        {
            throw new Exception("Invalid Id");
        }
        return data;
    }
    internal Review Create(Review newRev)
    {
        return _repo.Create(newRev);
    }

    internal Review Edit(Review updatedRev)
    {
      Review data = Get(updatedRev.Id);
      
    }

    internal Review Delete(int id)
    {
      throw new NotImplementedException();
    }

  }
}