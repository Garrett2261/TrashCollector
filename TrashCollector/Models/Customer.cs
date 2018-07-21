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
        public int TotalBill { get; set; }
        public string SuspensionStartDate { get; set; }
        public string SuspensionEndDate { get; set; }
        public int ZipCode { get; set; }

        //customer needs a bill
        //customer should not set bill
        //customer should have an amount that deals with the bill. It will be a boolean
        
        

    }
}