using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using jobContractor.Models;

namespace jobContractor.Repositories
{
  public class JobsRepository
  {
    private readonly IDbConnection _db;
    public JobsRepository(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<Job> Get()
    {
      string sql = "SELECT * FROM jobs";
      return _db.Query<Job>(sql);
    }

    internal object Get(int id)
    {
      string sql = "SELECT * FROM jobs WHERE id = @id";
      return _db.QueryFirstOrDefault<Job>(sql, new { id });
    }

    internal Job Create(Job newJob)
    {
      string sql = @"
        INSERT INTO jobs
        (location, contact, description)
        VALUES
        (@Location, @Contact, @Description);
        SELECT LAST_INSERT_ID();
        ";
      int id = _db.ExecuteScalar<int>(sql, newJob);
      newJob.Id = id;
      return newJob;
    }

    internal object Edit(Job updated)
    {
      string sql = @"
        UPDATE jobs
        SET
        location = @Location,
        contact = @Contact,
        description = @Description
        WHERE id = @Id;
        ";
      _db.Execute(sql, updated);
      return updated;
    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM jobs WHERE id = @Id";
      _db.Execute(sql, new { id });
    }
  }
}