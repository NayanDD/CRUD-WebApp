using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_WebApp.Models
{
    public class ProductTypeModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Product Name is expected")]
        public string Name { get; set; }

    }
}
