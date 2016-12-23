using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VUEJS.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string GoodName { get; set; }
        public int PersonId { get; set; }

        public Person Person { get; set; }
    }
}