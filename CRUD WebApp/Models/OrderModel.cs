using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_WebApp.Models
{
    public class OrderModel
    {
        // references
        public int ID { get; set; }

        [Required(ErrorMessage = "User ID is required")]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Payment ID is required")]
        public int PaymentID { get; set; }

        [Required(ErrorMessage = "Order ID is required")]
        public int OrderID { get; set; }

        [Required(ErrorMessage = "Shipper ID is is required")]
        public int ShipperID { get; set; }

       
        // internal use
        
        public string ErrorLoc { get; set; }

        public string ErrorMsg { get; set; }

        [Required(ErrorMessage = "isCompleted Status is required")]
        public bool isCompleted { get; set; }

        [Required(ErrorMessage = "isDeleted Status is required")]
        public bool isDeleted { get; set; }

        [Required(ErrorMessage = "isPaid Status is required")]
        public bool isPaid { get; set; }


        // external info for custome
        [Required]
        public DateTime PaymentDate { get; set;}

        [Required(ErrorMessage = "Transaction Status is required")]
        public int TransactionStatus { get; set; }

        [Required(ErrorMessage = "Payment Method is required")]
        public string PaymentMethod { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string ShippingAddress { get; set; }

        [Required(ErrorMessage = "Order Number is required")]
        public double OrderNumber { get; set; }

        [Required(ErrorMessage = "Total Amount is required")]
        [Range(0, 2147483647, ErrorMessage = "Total Amount Can't be negative")]
        public decimal TotalAmount { get; set; }


    }
}
