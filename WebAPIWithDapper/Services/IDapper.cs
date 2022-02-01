using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using WebAPIWithDapper.Models;

namespace WebAPIWithDapper.Services
{
    public interface IDapper : IDisposable
    {
        //DbConnection GetDbconnection();
        Product GetProductById(int Id);
        List<Product> GetAll();
        int Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        T Insert<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        T Update<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
    }
}
