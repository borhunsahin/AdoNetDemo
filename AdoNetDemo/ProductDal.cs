using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=E-Trade; integrated security=true");
        public List<Product> GetAll()
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("SELECT * FROM Products",_connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();
            while(reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Stock = Convert.ToInt32(reader["Stock"]),
                    Price = Convert.ToDecimal(reader["Price"])
                };
                products.Add(product);
            }

            reader.Close();
            _connection.Close();
            return products;
        }
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("INSERT INTO Products VALUES(@name,@price,@stock)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@price", product.Price);
            command.Parameters.AddWithValue("@stock", product.Stock);
            
            command.ExecuteNonQuery();

            _connection.Close();
        }
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("UPDATE Products SET Name=@name, Price=@price, Stock=@stock WHERE Id=@id", _connection);
            
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@price", product.Price);
            command.Parameters.AddWithValue("@stock", product.Stock);
            command.Parameters.AddWithValue("@id", product.Id);

            command.ExecuteNonQuery();

            _connection.Close();
        }
        public void Delete (int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("DELETE FROM Products WHERE Id=@id", _connection);

            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
