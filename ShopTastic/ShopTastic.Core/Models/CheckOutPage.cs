using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTastic.Core.Models
{
    class CheckOutPage:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public string ZipCode { get; set; }
        [Phone]
        public string MobilePhone { get; set; }
        public string EmailAdress { get; set; }
    }
}
