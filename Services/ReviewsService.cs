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
      updatedRev.Title = updatedRev.Title != null ? updatedRev.Title : data.Title;
      updatedRev.Rating = updatedRev.Rating != null ? updatedRev.Rating : data.Rating;
      updatedRev.Date = updatedRev.Date != null ? updatedRev.Date : data.Date;
      updatedRev.Body = updatedRev.Body != null ? updatedRev.Body : data.Body;
      updatedRev.ContractorId = updatedRev.ContractorId != null ? updatedRev.ContractorId : data.ContractorId;
      return _repo.Edit(updatedRev);
    }

    internal string Delete(int id)
    {
      Review data = Get(id);
      _repo.Delete(id);
      return "Deleted Review";
    }

  }
}