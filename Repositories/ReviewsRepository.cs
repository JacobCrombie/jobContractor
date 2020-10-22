using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using jobContractor.Models;

namespace jobContractor.Repositories
{
  public class ReviewsRepository
  {
    private readonly IDbConnection _db;

    public ReviewsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Review> Get()
    {
      string sql = "SELECT * FROM reviews";
      return _db.Query<Review>(sql);
    }

    internal Review Get(int id)
    {
      string sql = "SELECT * FROM reviews WHERE id = @id";
      return _db.QueryFirstOrDefault<Review>(sql, new { id });
    }

    internal Review Create(Review newRev)
    {
      string sql = @"
      INSERT INTO reviews
      (title, body, rating, date, contractorid)
      VALUES
      (@Title, @Body, @Rating, @Date, @ContractorId)
      SELECT LAST_INSERT_ID();
      ";
      int id = _db.ExecuteScalar<int>(sql, newRev);
      newRev.Id = id;
      return newRev;
    }

    internal Review Edit(Review updatedRev)
    {
      string sql = @"
      UPDATE reviews
      SET
      title = @Title,
      body = @Body,
      rating = @Rating,
      date = @Date,
      contractorid = @ContractorId;
      ";
      _db.Execute(sql, updatedRev);
      return updatedRev;
    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM reviews WHERE id = @Id";
      _db.Execute(sql, new { id });
    }
  }
}