using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace CRUD_WebApp.Models
{
    public class ProductDAL
    {
        string connectionString = "Data Source=WOBBLYBOX/SQLEXPRESS;Initial Catalog=WebShopDB;Persist Security Info=False;User Id=WOBBLYBOX/Asdamar;;MultipleActiveResultSets=True";


        // get all products from database
        public IEnumerable<ProductModel> GetAllProduct()
        {
            List<ProductModel> productList = new List<ProductModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_GetAllProduct", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    ProductModel product = new ProductModel();
                    product.ID = Convert.ToInt32( dr["ID"].ToString());
                    product.TypeID = Convert.ToInt32( dr["TypeID"].ToString());
                    product.Name = dr["Name"].ToString();
                    product.Price = Convert.ToDecimal( dr["Price"].ToString());
                    product.Description = dr["Description"].ToString();
                    product.Quantity = Convert.ToInt32( dr["Quantity"].ToString());
                    product.isVisible = Convert.ToBoolean(dr["isVisible"].ToString());
                    product.isAvailable = Convert.ToBoolean(dr["isAvailable"].ToString());
                    product.Image = dr["Image"].ToString();

                    productList.Add(product);
                }
                con.Close();
            }
            return productList;
        }

        public void AddProduct(ProductModel product)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_InsertProducts", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TypeID", product.TypeID);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Description", product.Description);
                cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                cmd.Parameters.AddWithValue("@isVisible", product.isVisible);
                cmd.Parameters.AddWithValue("@isAvailable", product.isAvailable);
                cmd.Parameters.AddWithValue("@Image", product.Image);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void UpdateProduct(ProductModel product)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_UpdateProducts", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", product.ID);
                cmd.Parameters.AddWithValue("@TypeID", product.TypeID);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Description", product.Description);
                cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                cmd.Parameters.AddWithValue("@isVisible", product.isVisible);
                cmd.Parameters.AddWithValue("@isAvailable", product.isAvailable);
                cmd.Parameters.AddWithValue("@Image", product.Image);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


    }

}
