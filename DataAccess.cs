using MiniMart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace MiniMart
{
    public class DataAccess
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            using (var connection = new SqlConnection(Config.ConString))
            {
                products = connection.Query<Product>("select * from Product").ToList();
            }
            return products;
        }

        public void InsertProduct(string name, string category, float salePrice)
        {
            List<Product> products = new List<Product>() { new Product() { Name = name, Category = category, SalePrice = salePrice } };
            using (var connection = new SqlConnection(Config.ConString))
            {
                connection.Execute("insert into Product (Name, Category, SalePrice) values (@Name, @Category, @SalePrice)", products);
            }
        }

        internal void UpdateProduct(int id, string name, string category, float salePrice)
        {
            Product p = new Product() { ID = id, Name = name, Category = category, SalePrice = salePrice };
            using (var connection = new SqlConnection(Config.ConString))
            {
                connection.Execute("update Product set Name = @Name, Category = @Category, SalePrice = @SalePrice Where ID = @ID", p);
            }
        }

        internal void DeleteProduct(int id)
        {
            using (var connection = new SqlConnection(Config.ConString))
            {
                connection.Execute("delete from Product where ID = @ID", new { ID = id });
            }
        }
    }
}
