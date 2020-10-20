using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using jobContractor.Models;

namespace jobContractor.Repositories
{
    public class ContractorsRepository
    {
        private readonly IDbConnection _db;
        public ContractorsRepository(IDbConnection db)
        {
            _db = db;
        }

        internal IEnumerable<Contractor> Get()
        {
            string sql = "SELECT * FROM contractors";
            return _db.Query<Contractor>(sql);
        }

    internal object Get(int id)
    {
        string sql = "SELECT * FROM contractors WHERE id = @id";
        return _db.QueryFirstOrDefault<Contractor>(sql, new {id});
    }
  }
}