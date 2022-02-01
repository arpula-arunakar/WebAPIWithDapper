using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using WebAPIWithDapper.Data;
using WebAPIWithDapper.Models;

namespace WebAPIWithDapper.Services
{
    public class Dapperrr : IDapper
    {
        private IConfiguration _config;
        //private IDbConnection db;
        public string Connectionstring = "DefaultConnectionString";

        //public Dapperrr(IConfiguration config)
        //{
        //    _config = config;
        //    this.db = new SqlConnection(_config.GetConnectionString(Connectionstring));
        //}

        private readonly DapperContext _context;
        public Dapperrr(DapperContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
            //this.db = context.CreateConnection();
        }

        public void Dispose()
        {
        }

        public int Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            throw new System.NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            using(var _db = _context.CreateConnection())
            {
                var cmd = "select * from products where id =@ProductId";
                return _db.Query<Product>(cmd, new { ProductId = id }).FirstOrDefault();
                //return db.Query<Product>(cmd, new { ProductId = id }).FirstOrDefault();
            }
        }

        public List<Product> GetAll()
        {
            using(var _db= _context.CreateConnection())
            {
                var cmd = "select * from products";
                //var data = db.Query<Product>(cmd).ToList();
                var data = _db.Query<Product>(cmd).ToList();
                return data;
            }
        }


        public T Insert<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            throw new System.NotImplementedException();
        }

        public T Update<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            throw new System.NotImplementedException();
        }
    }
}
