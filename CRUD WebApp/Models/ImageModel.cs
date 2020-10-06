using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_WebApp.Models
{
    public class ImageModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "File path is expected")]
        public string FilePath { get; set; }

        public string Description { get; set; }


    }
}
