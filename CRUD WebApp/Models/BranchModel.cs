using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_WebApp.Models
{
    public class BranchModel
    {

        public int ID { get; set; }

        [Required(ErrorMessage = "Branch name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location must be specified")]
        public string Location { get; set; }

    }
}
