using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_WebApp.Models
{
    public class CartModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Clinet ID is expected")]
        public int ClientID { get; set; }

        [Required(ErrorMessage = "Product ID is expected")]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "OrderID is expected")]
        public int OrderID { get; set; }

        [Required(ErrorMessage = "Total Amount is expected")][Range(0, 2147483647, ErrorMessage = "Total Amount Can't be negative")]
        public decimal TotalAmount { get; set; }

        //internal use
        [Required(ErrorMessage = "isInCart expected")]
        public bool isInCart { get; set; }

        [Required(ErrorMessage = "DatePurchased expected")]
        public DateTime DatePurchased { get; set; }



        /* Legacy code
         * 
         * 
        public string InsertCart(Cart cart)
        {
            try
            {
                DBEntities dbo = new DBEntities();
                dbo.Carts.Add(cart);
                dbo.SaveChanges();

                return cart.DatePurchased + " was successfully inserted";

            }
            catch(Exception e)
            {
                return "Error: " + e;
            }

        }
        
        public string UpdateCart(int id, Cart cart)
        {

            try
            {
                DBEntities dbo = new DBEntities();

                //fetch from db
                Cart c = dbo.Carts.Find(id);

                c.DatePurchased = cart.DatePurchased;
                c.ClientID = cart.ClientID;
                c.Amount = cart.Amount;
                c.IsInCart = cart.IsInCart;
                c.ProductID = cart.ProductID;
                c.OrderID = cart.OrderID;


                dbo.SaveChanges();
                return cart.DatePurchased + " was succesfully updated";

            }
            catch (Exception e)
            {
                return "Error: " + e;
            }

        }

        public string DeleteCart(int id)
        {

            try
            {
                DBEntities dbo = new DBEntities();
                Cart cart = dbo.Carts.Find(id);

                dbo.Carts.Attach(cart);
                dbo.Carts.Remove(cart);
                dbo.SaveChanges();

                return cart.DatePurchased + " was succesfully deleted";



            }
            catch (Exception e)
            {
                return "Error: " + e;
            }

        }

        public List<Cart> GetOrdersInCart(string userId)
        {
            DBEntities dbo = new DBEntities();
            List<Cart> orders = (from x in dbo.Carts where x.ClientID == userId && x.IsInCart orderby x.DatePurchased select x).ToList();
            return orders;
        }

        public int GetAmountOfOrders(string userId)
        {
            try
            {
                DBEntities dbo = new DBEntities();
                int amount = (from x in dbo.Carts
                              where x.ClientID == userId && x.IsInCart
                              select x.Amount).Sum();
                return amount;

            }
            catch
            {

                return 0;
            }

        }

        public void UpdateQuantity(int id, int quantity)
        {
            DBEntities dbo = new DBEntities();
            Cart cart = dbo.Carts.Find(id);
            cart.Amount = quantity;
            dbo.SaveChanges();

        }

        public void MarkOrdersAsPaid(List<Cart> carts)
        {

            // payment...?
            DBEntities dbo = new DBEntities();
            if (carts != null)
            {
                foreach (Cart cart in carts)
                {

                    Cart oldCart = dbo.Carts.Find(cart.ID);
                    oldCart.DatePurchased = DateTime.Now;
                    oldCart.IsInCart = false;

                    // TODO
                    // could use some improvement code with table "Order"

                }

                dbo.SaveChanges();

            }

        }
        */

    }
}
