using System;
using System.Collections.Generic;
using jobContractor.Models;
using jobContractor.Repositories;

namespace jobContractor.Services
{
  public class JobsService
  {
    private readonly JobsRepository _repo;
    public JobsService(JobsRepository repo)
    {
      _repo = repo;
    }
    internal IEnumerable<Job> Get()
    {
      return _repo.Get();
    }

    internal Job Get(int id)
    {
      var data = _repo.Get(id);
      if (data == null)
      {
        throw new Exception("Invalid Id");
      }
      return (Job)data;
    }

    internal object Create(Job newJob)
    {
      return _repo.Create(newJob);
    }

    internal object Edit(Job updated)
    {
      var data = Get(updated.Id);
      updated.Location = updated.Location != null ? updated.Location : data.Location;
      updated.Description = updated.Description != null ? updated.Description : data.Description;
      return _repo.Edit(updated);
    }

    internal object Delete(int id)
    {
      var data = Get(id);
      _repo.Delete(id);
      return "Deleted Job";
    }
  }
}