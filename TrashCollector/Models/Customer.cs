using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customers
    {
        [Key]
        public int ID { get; set; }
        public string PickupDay { get; set; }
        public string ExtraPickupDay { get; set; }
        public double MonthlyCost { get; set; }
        public string SuspensionStartDay { get; set; }
        public string SuspensionEndDay { get; set; }

        //customer needs a bill
        //customer should not set bill
        //customer should have an amount that deals with the bill. It will be a boolean
        
        

    }
}