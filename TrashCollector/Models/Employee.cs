using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public bool ConfirmPickup { get; set; }
        public int ChargedPrice { get; set; }
        public int ZipCode { get; set; }

    }
}