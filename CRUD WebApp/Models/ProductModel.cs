using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_WebApp.Models
{
    public class ProductModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Type ID is expected")]
        public int TypeID { get; set; }

        [Required(ErrorMessage = "Product Name is expected")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0, 2147483647, ErrorMessage = "Price Can't be negative")]
        public decimal Price { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Quantity is expected")][Range(0, 2147483647, ErrorMessage = "Quantity cannot be negative")]
        public int Quantity { get; set; }


        // internal use
        [Required(ErrorMessage = "Set the visibility of the product to True or False to make it visible to the customers or not")]
        public bool isVisible { get; set; }

        [Required(ErrorMessage = "Set the availability of the product to True or False to make show the customers whether the product is (Available) or (Not Available)")]
        public bool isAvailable { get; set; }

        public string Image { get; set; }
    }
}
